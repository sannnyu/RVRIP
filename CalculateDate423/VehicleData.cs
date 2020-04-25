﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CalculateDate423
{

    public class VehicleData
    {


        public enum vehicleGenType
        {
            Spc70t = 3,//特殊情况
            Gen70t = 0,//70吨通用公式
            Gen60t = 1//60吨通用公式
        }

        public vehicleGenType GenType { get; set; }
        public string vehicleNumber { get; set; }
        public DateTime previousDepotDate { get; set; }//上次段修
        public DateTime previousFactoryDate { get; set; }//上次厂修

        //public DateTime currentDepDate { get; set; }//本次段修
        //public DateTime currentFacDate { get; set; }//本次厂修 //需要吗？
        public DateTime nextDepDate { get; set; }
        public DateTime nextFacDate { get; set; }
        //public DateTime produceDate { get; set; }


        public VehicleData DateProcessKernel(int GenTp, DateTime pre_depDate, DateTime pre_facDate, DateTime produceDate, int SealSpan)
        {

            VehicleData vehicle = new VehicleData();
            vehicle.previousDepotDate = pre_depDate;
            vehicle.previousFactoryDate = pre_facDate;

            //计算上次段修距离上次厂修的时间差
            //Gate用来储存时间差
            int Gate_year = pre_depDate.Year - pre_facDate.Year;
            int Gate_month = pre_depDate.Month - pre_facDate.Month;
            int Gate_sum = Gate_year * 12 + Gate_month;


            //70t通用.
            if (GenTp == 0)
            {

                //现在是第几次段修
                //70t是两年一次段修所以都是整数，只需要用年来除
                int dep_count = Gate_year / 2;

                //此时开始判断是否需要加强段修。开始分类,判断特殊情况。
                int predictFacDate = pre_facDate.Year + 8;
                if (predictFacDate == 2020 || predictFacDate == 2021)
                {
                    //GenTp = 2;//70t的特殊情况，需要加强段修.但后面不再需要GenTp此参数，由描述车型更精确的vehicle.GenType替代
                    vehicle.GenType = vehicleGenType.Spc70t;

                }
                else
                {
                    vehicle.GenType = vehicleGenType.Gen70t;
                }


                //段修修程为24个月 n为第几次段修
                int n = (int)Math.Round((double)(Gate_sum / 24), 0);//四舍五入为了减少误差
                vehicle.previousDepotDate = vehicle.previousFactoryDate.AddMonths(n * 24);

                switch (vehicle.GenType)
                {
                    case vehicleGenType.Gen70t:

                        //计算增加修程
                        //将前n次的24个月+剩下的6-n次的20个月加入到上次厂修 即可求出下次厂修时间
                        vehicle.nextFacDate = vehicle.previousFactoryDate.AddMonths((6 - n) * 27 + n * 24);

                        //拿修正后的段修时间+封存期，判断第n次段修是否在2020-2.ye021修程修制改革时间内
                        DateTime sealEndTime = vehicle.previousDepotDate.AddMonths(SealSpan);
                        if (sealEndTime.Year == 2020 || sealEndTime.Year == 2021)
                        {
                            //在2020-2011期间，则先加两年再加3个月，得到下一次厂修日期
                            vehicle.nextDepDate = sealEndTime.AddMonths(24).AddMonths(3);
                            vehicle.nextFacDate = vehicle.previousFactoryDate.AddMonths((4 - n) * 27 + n * 24).AddMonths(3);
                        }
                        else
                        {
                            //如果不在2020-2011，则按照正常算
                            vehicle.nextFacDate = vehicle.previousFactoryDate.AddMonths((4 - n) * 27 + n * 24);
                        }


                        break;


                    case vehicleGenType.Spc70t:


                        //首先判断n是否为3，保险起见
                        if (n != 3)
                        {
                            //第一次做加强段修，不增加修程
                            //本次为加强段修，下次做厂修
                            vehicle.nextFacDate = produceDate.AddMonths(24 * 5);

                            //求加强段修时间？


                        }
                        else
                        {
                            vehicle = null;
                        }

                        break;

                    default:
                        vehicle = null;
                        break;

                }












            }

            //60t通用
            else if (GenTp == 1)
            {
                //段修修程为18个月 n为第几次段修
                int n = (int)Math.Round((double)(Gate_sum / 18), 0);//四舍五入为了减少误差
                //计算增加修程
                //将前n次的18个月+剩下的6-n次的20个月加入到上次厂修 即可求出下次厂修时间
                vehicle.nextFacDate = vehicle.previousFactoryDate.AddMonths((6 - n) * 20 + n * 18);
                //修正上次段修时间
                vehicle.previousDepotDate = vehicle.previousFactoryDate.AddMonths(n * 18);
                //ToDo: 加入封存备用期




            }
            else//其他车就不用改修程
            {
                //其他车都是60t的车都是水泥罐之类的，1.5年修一次，5个段修，9年做一次厂修

                //其他车暂时不写
                vehicle = null;
            }

            return vehicle;
        }




    }
}
