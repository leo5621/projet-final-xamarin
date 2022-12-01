using System;
using System.Net;
using System.Windows;
using System.Collections.Generic;
using System.Drawing;

namespace ProjetNote
{
    internal class SCORE2ESC
    {


        Dictionary<string, Dictionary<string, Dictionary<string, Dictionary<string, Dictionary<string, int>>>>> SCORE2 = new Dictionary<string, Dictionary<string, Dictionary<string, Dictionary<string, Dictionary<string, int>>>>>();
        Dictionary<string, Dictionary<string, int>> dicoTAS = new Dictionary<string, Dictionary<string, int>>();
        Dictionary<string, Dictionary<string, Dictionary<string, int>>> dicoAge = new Dictionary<string, Dictionary<string, Dictionary<string, int>>>();
        Dictionary<string, Dictionary<string, Dictionary<string, Dictionary<string, int>>>> dicoSMOKER = new Dictionary<string, Dictionary<string, Dictionary<string, Dictionary<string, int>>>>();
        Dictionary<string, int> dicoNonHDL = new Dictionary<string, int>();



        public SCORE2ESC()
        {
            /* ====================================================================== */
            #region "       WOMAN"
            /* ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~ */


            /* ====================================================================== */
            #region "       NON SMOKING"
            /* ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~ */
            //  
            //WOMAN NON SMOKING + 40-44
            var dicoNonHDL = new Dictionary<string, int>();
            dicoNonHDL.Add("3.0-3.9", 1);
            dicoNonHDL.Add("4.0-4.9", 1);
            dicoNonHDL.Add("5.0-5.9", 1);
            dicoNonHDL.Add("6.0-6.9", 1);
            dicoTAS.Add("100-119", dicoNonHDL);

            dicoNonHDL = new Dictionary<string, int>();
            dicoNonHDL.Add("3.0-3.9", 1);
            dicoNonHDL.Add("4.0-4.9", 1);
            dicoNonHDL.Add("5.0-5.9", 1);
            dicoNonHDL.Add("6.0-6.9", 1);
            dicoTAS.Add("120-139", dicoNonHDL);

            dicoNonHDL = new Dictionary<string, int>();
            dicoNonHDL.Add("3.0-3.9", 1);
            dicoNonHDL.Add("4.0-4.9", 2);
            dicoNonHDL.Add("5.0-5.9", 2);
            dicoNonHDL.Add("6.0-6.9", 2);
            dicoTAS.Add("140-159", dicoNonHDL);

            dicoNonHDL = new Dictionary<string, int>();
            dicoNonHDL.Add("3.0-3.9", 2);
            dicoNonHDL.Add("4.0-4.9", 2);
            dicoNonHDL.Add("5.0-5.9", 2);
            dicoNonHDL.Add("6.0-6.9", 3);
            dicoTAS.Add("160-179", dicoNonHDL);

            dicoAge.Add("40-44", dicoTAS);

            //WOMAN NON SMOKING + 45-49
            dicoTAS = new Dictionary<string, Dictionary<string, int>>();

            dicoNonHDL = new Dictionary<string, int>();
            dicoNonHDL.Add("3.0-3.9", 1);
            dicoNonHDL.Add("4.0-4.9", 1);
            dicoNonHDL.Add("5.0-5.9", 1);
            dicoNonHDL.Add("6.0-6.9", 1);
            dicoTAS.Add("100-119", dicoNonHDL);

            dicoNonHDL = new Dictionary<string, int>();
            dicoNonHDL.Add("3.0-3.9", 1);
            dicoNonHDL.Add("4.0-4.9", 2);
            dicoNonHDL.Add("5.0-5.9", 2);
            dicoNonHDL.Add("6.0-6.9", 2);
            dicoTAS.Add("120-139", dicoNonHDL);

            dicoNonHDL = new Dictionary<string, int>();
            dicoNonHDL.Add("3.0-3.9", 2);
            dicoNonHDL.Add("4.0-4.9", 2);
            dicoNonHDL.Add("5.0-5.9", 2);
            dicoNonHDL.Add("6.0-6.9", 3);
            dicoTAS.Add("140-159", dicoNonHDL);

            dicoNonHDL = new Dictionary<string, int>();
            dicoNonHDL.Add("3.0-3.9", 2);
            dicoNonHDL.Add("4.0-4.9", 3);
            dicoNonHDL.Add("5.0-5.9", 3);
            dicoNonHDL.Add("6.0-6.9", 3);
            dicoTAS.Add("160-179", dicoNonHDL);

            dicoAge.Add("45-49", dicoTAS);

            //WOMAN NON SMOKING + 50-54
            dicoTAS = new Dictionary<string, Dictionary<string, int>>();

            dicoNonHDL = new Dictionary<string, int>();
            dicoNonHDL.Add("3.0-3.9", 2);
            dicoNonHDL.Add("4.0-4.9", 2);
            dicoNonHDL.Add("5.0-5.9", 2);
            dicoNonHDL.Add("6.0-6.9", 2);
            dicoTAS.Add("100-119", dicoNonHDL);

            dicoNonHDL = new Dictionary<string, int>();
            dicoNonHDL.Add("3.0-3.9", 2);
            dicoNonHDL.Add("4.0-4.9", 2);
            dicoNonHDL.Add("5.0-5.9", 2);
            dicoNonHDL.Add("6.0-6.9", 3);
            dicoTAS.Add("120-139", dicoNonHDL);

            dicoNonHDL = new Dictionary<string, int>();
            dicoNonHDL.Add("3.0-3.9", 3);
            dicoNonHDL.Add("4.0-4.9", 3);
            dicoNonHDL.Add("5.0-5.9", 3);
            dicoNonHDL.Add("6.0-6.9", 3);
            dicoTAS.Add("140-159", dicoNonHDL);

            dicoNonHDL = new Dictionary<string, int>();
            dicoNonHDL.Add("3.0-3.9", 3);
            dicoNonHDL.Add("4.0-4.9", 4);
            dicoNonHDL.Add("5.0-5.9", 4);
            dicoNonHDL.Add("6.0-6.9", 4);
            dicoTAS.Add("160-179", dicoNonHDL);

            dicoAge.Add("50-54", dicoTAS);

            //WOMAN NON SMOKING + 55-59
            dicoTAS = new Dictionary<string, Dictionary<string, int>>();

            dicoNonHDL = new Dictionary<string, int>();
            dicoNonHDL.Add("3.0-3.9", 2);
            dicoNonHDL.Add("4.0-4.9", 2);
            dicoNonHDL.Add("5.0-5.9", 3);
            dicoNonHDL.Add("6.0-6.9", 3);
            dicoTAS.Add("100-119", dicoNonHDL);

            dicoNonHDL = new Dictionary<string, int>();
            dicoNonHDL.Add("3.0-3.9", 3);
            dicoNonHDL.Add("4.0-4.9", 3);
            dicoNonHDL.Add("5.0-5.9", 3);
            dicoNonHDL.Add("6.0-6.9", 3);
            dicoTAS.Add("120-139", dicoNonHDL);

            dicoNonHDL = new Dictionary<string, int>();
            dicoNonHDL.Add("3.0-3.9", 3);
            dicoNonHDL.Add("4.0-4.9", 4);
            dicoNonHDL.Add("5.0-5.9", 4);
            dicoNonHDL.Add("6.0-6.9", 4);
            dicoTAS.Add("140-159", dicoNonHDL);

            dicoNonHDL = new Dictionary<string, int>();
            dicoNonHDL.Add("3.0-3.9", 4);
            dicoNonHDL.Add("4.0-4.9", 5);
            dicoNonHDL.Add("5.0-5.9", 5);
            dicoNonHDL.Add("6.0-6.9", 5);
            dicoTAS.Add("160-179", dicoNonHDL);

            dicoAge.Add("55-59", dicoTAS);



            //WOMAN NON SMOKING + 60-64
            dicoTAS = new Dictionary<string, Dictionary<string, int>>();

            dicoNonHDL = new Dictionary<string, int>();
            dicoNonHDL.Add("3.0-3.9", 3);
            dicoNonHDL.Add("4.0-4.9", 3);
            dicoNonHDL.Add("5.0-5.9", 4);
            dicoNonHDL.Add("6.0-6.9", 4);
            dicoTAS.Add("100-119", dicoNonHDL);

            dicoNonHDL = new Dictionary<string, int>();
            dicoNonHDL.Add("3.0-3.9", 4);
            dicoNonHDL.Add("4.0-4.9", 4);
            dicoNonHDL.Add("5.0-5.9", 4);
            dicoNonHDL.Add("6.0-6.9", 5);
            dicoTAS.Add("120-139", dicoNonHDL);

            dicoNonHDL = new Dictionary<string, int>();
            dicoNonHDL.Add("3.0-3.9", 5);
            dicoNonHDL.Add("4.0-4.9", 5);
            dicoNonHDL.Add("5.0-5.9", 5);
            dicoNonHDL.Add("6.0-6.9", 6);
            dicoTAS.Add("140-159", dicoNonHDL);

            dicoNonHDL = new Dictionary<string, int>();
            dicoNonHDL.Add("3.0-3.9", 6);
            dicoNonHDL.Add("4.0-4.9", 6);
            dicoNonHDL.Add("5.0-5.9", 7);
            dicoNonHDL.Add("6.0-6.9", 7);
            dicoTAS.Add("160-179", dicoNonHDL);

            dicoAge.Add("60-64", dicoTAS);

            //WOMAN NON SMOKING + 65-69
            dicoTAS = new Dictionary<string, Dictionary<string, int>>();

            dicoNonHDL = new Dictionary<string, int>();
            dicoNonHDL.Add("3.0-3.9", 5);
            dicoNonHDL.Add("4.0-4.9", 5);
            dicoNonHDL.Add("5.0-5.9", 5);
            dicoNonHDL.Add("6.0-6.9", 5);
            dicoTAS.Add("100-119", dicoNonHDL);

            dicoNonHDL = new Dictionary<string, int>();
            dicoNonHDL.Add("3.0-3.9", 5);
            dicoNonHDL.Add("4.0-4.9", 6);
            dicoNonHDL.Add("5.0-5.9", 6);
            dicoNonHDL.Add("6.0-6.9", 6);
            dicoTAS.Add("120-139", dicoNonHDL);

            dicoNonHDL = new Dictionary<string, int>();
            dicoNonHDL.Add("3.0-3.9", 7);
            dicoNonHDL.Add("4.0-4.9", 7);
            dicoNonHDL.Add("5.0-5.9", 7);
            dicoNonHDL.Add("6.0-6.9", 7);
            dicoTAS.Add("140-159", dicoNonHDL);

            dicoNonHDL = new Dictionary<string, int>();
            dicoNonHDL.Add("3.0-3.9", 8);
            dicoNonHDL.Add("4.0-4.9", 8);
            dicoNonHDL.Add("5.0-5.9", 9);
            dicoNonHDL.Add("6.0-6.9", 9);
            dicoTAS.Add("160-179", dicoNonHDL);

            dicoAge.Add("65-69", dicoTAS);

            //WOMAN NON SMOKING + 70-74
            dicoTAS = new Dictionary<string, Dictionary<string, int>>();

            dicoNonHDL = new Dictionary<string, int>();
            dicoNonHDL.Add("3.0-3.9", 6);
            dicoNonHDL.Add("4.0-4.9", 6);
            dicoNonHDL.Add("5.0-5.9", 6);
            dicoNonHDL.Add("6.0-6.9", 7);
            dicoTAS.Add("100-119", dicoNonHDL);

            dicoNonHDL = new Dictionary<string, int>();
            dicoNonHDL.Add("3.0-3.9", 7);
            dicoNonHDL.Add("4.0-4.9", 7);
            dicoNonHDL.Add("5.0-5.9", 8);
            dicoNonHDL.Add("6.0-6.9", 8);
            dicoTAS.Add("120-139", dicoNonHDL);

            dicoNonHDL = new Dictionary<string, int>();
            dicoNonHDL.Add("3.0-3.9", 9);
            dicoNonHDL.Add("4.0-4.9", 9);
            dicoNonHDL.Add("5.0-5.9", 10);
            dicoNonHDL.Add("6.0-6.9", 10);
            dicoTAS.Add("140-159", dicoNonHDL);

            dicoNonHDL = new Dictionary<string, int>();
            dicoNonHDL.Add("3.0-3.9", 10);
            dicoNonHDL.Add("4.0-4.9", 11);
            dicoNonHDL.Add("5.0-5.9", 12);
            dicoNonHDL.Add("6.0-6.9", 12);
            dicoTAS.Add("160-179", dicoNonHDL);

            dicoAge.Add("70-74", dicoTAS);

            //WOMAN NON SMOKING + 75-79
            dicoTAS = new Dictionary<string, Dictionary<string, int>>();

            dicoNonHDL = new Dictionary<string, int>();
            dicoNonHDL.Add("3.0-3.9", 9);
            dicoNonHDL.Add("4.0-4.9", 10);
            dicoNonHDL.Add("5.0-5.9", 10);
            dicoNonHDL.Add("6.0-6.9", 11);
            dicoTAS.Add("100-119", dicoNonHDL);

            dicoNonHDL = new Dictionary<string, int>();
            dicoNonHDL.Add("3.0-3.9", 11);
            dicoNonHDL.Add("4.0-4.9", 11);
            dicoNonHDL.Add("5.0-5.9", 12);
            dicoNonHDL.Add("6.0-6.9", 13);
            dicoTAS.Add("120-139", dicoNonHDL);

            dicoNonHDL = new Dictionary<string, int>();
            dicoNonHDL.Add("3.0-3.9", 13);
            dicoNonHDL.Add("4.0-4.9", 13);
            dicoNonHDL.Add("5.0-5.9", 14);
            dicoNonHDL.Add("6.0-6.9", 15);
            dicoTAS.Add("140-159", dicoNonHDL);

            dicoNonHDL = new Dictionary<string, int>();
            dicoNonHDL.Add("3.0-3.9", 15);
            dicoNonHDL.Add("4.0-4.9", 15);
            dicoNonHDL.Add("5.0-5.9", 16);
            dicoNonHDL.Add("6.0-6.9", 17);
            dicoTAS.Add("160-179", dicoNonHDL);

            dicoAge.Add("75-79", dicoTAS);

            //WOMAN NON SMOKING + 80-84
            dicoTAS = new Dictionary<string, Dictionary<string, int>>();

            dicoNonHDL = new Dictionary<string, int>();
            dicoNonHDL.Add("3.0-3.9", 15);
            dicoNonHDL.Add("4.0-4.9", 15);
            dicoNonHDL.Add("5.0-5.9", 16);
            dicoNonHDL.Add("6.0-6.9", 17);
            dicoTAS.Add("100-119", dicoNonHDL);

            dicoNonHDL = new Dictionary<string, int>();
            dicoNonHDL.Add("3.0-3.9", 16);
            dicoNonHDL.Add("4.0-4.9", 17);
            dicoNonHDL.Add("5.0-5.9", 18);
            dicoNonHDL.Add("6.0-6.9", 19);
            dicoTAS.Add("120-139", dicoNonHDL);

            dicoNonHDL = new Dictionary<string, int>();
            dicoNonHDL.Add("3.0-3.9", 18);
            dicoNonHDL.Add("4.0-4.9", 19);
            dicoNonHDL.Add("5.0-5.9", 20);
            dicoNonHDL.Add("6.0-6.9", 21);
            dicoTAS.Add("140-159", dicoNonHDL);

            dicoNonHDL = new Dictionary<string, int>();
            dicoNonHDL.Add("3.0-3.9", 20);
            dicoNonHDL.Add("4.0-4.9", 21);
            dicoNonHDL.Add("5.0-5.9", 22);
            dicoNonHDL.Add("6.0-6.9", 23);
            dicoTAS.Add("160-179", dicoNonHDL);

            dicoAge.Add("80-84", dicoTAS);


            //WOMAN NON SMOKING + 85-89
            dicoTAS = new Dictionary<string, Dictionary<string, int>>();

            dicoNonHDL = new Dictionary<string, int>();
            dicoNonHDL.Add("3.0-3.9", 23);
            dicoNonHDL.Add("4.0-4.9", 24);
            dicoNonHDL.Add("5.0-5.9", 25);
            dicoNonHDL.Add("6.0-6.9", 26);
            dicoTAS.Add("100-119", dicoNonHDL);

            dicoNonHDL = new Dictionary<string, int>();
            dicoNonHDL.Add("3.0-3.9", 24);
            dicoNonHDL.Add("4.0-4.9", 25);
            dicoNonHDL.Add("5.0-5.9", 26);
            dicoNonHDL.Add("6.0-6.9", 27);
            dicoTAS.Add("120-139", dicoNonHDL);

            dicoNonHDL = new Dictionary<string, int>();
            dicoNonHDL.Add("3.0-3.9", 26);
            dicoNonHDL.Add("4.0-4.9", 27);
            dicoNonHDL.Add("5.0-5.9", 28);
            dicoNonHDL.Add("6.0-6.9", 29);
            dicoTAS.Add("140-159", dicoNonHDL);

            dicoNonHDL = new Dictionary<string, int>();
            dicoNonHDL.Add("3.0-3.9", 28);
            dicoNonHDL.Add("4.0-4.9", 29);
            dicoNonHDL.Add("5.0-5.9", 30);
            dicoNonHDL.Add("6.0-6.9", 31);
            dicoTAS.Add("160-179", dicoNonHDL);

            dicoAge.Add("85-89", dicoTAS);

            dicoSMOKER.Add("NON-SMOKER", dicoAge);
            dicoAge = new Dictionary<string, Dictionary<string, Dictionary<string, int>>>();

            #endregion "       NON SMOKING"
            /* ====================================================================== */


            /* ====================================================================== */
            #region "       SMOKING"
            /* ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~ */
            //  
            dicoTAS = new Dictionary<string, Dictionary<string, int>>();

            //WOMAN SMOKING + 40-44
            dicoNonHDL = new Dictionary<string, int>();
            dicoNonHDL.Add("3.0-3.9", 2);
            dicoNonHDL.Add("4.0-4.9", 2);
            dicoNonHDL.Add("5.0-5.9", 2);
            dicoNonHDL.Add("6.0-6.9", 2);
            dicoTAS.Add("100-119", dicoNonHDL);

            dicoNonHDL = new Dictionary<string, int>();
            dicoNonHDL.Add("3.0-3.9", 2);
            dicoNonHDL.Add("4.0-4.9", 3);
            dicoNonHDL.Add("5.0-5.9", 3);
            dicoNonHDL.Add("6.0-6.9", 3);
            dicoTAS.Add("120-139", dicoNonHDL);

            dicoNonHDL = new Dictionary<string, int>();
            dicoNonHDL.Add("3.0-3.9", 3);
            dicoNonHDL.Add("4.0-4.9", 3);
            dicoNonHDL.Add("5.0-5.9", 4);
            dicoNonHDL.Add("6.0-6.9", 4);
            dicoTAS.Add("140-159", dicoNonHDL);

            dicoNonHDL = new Dictionary<string, int>();
            dicoNonHDL.Add("3.0-3.9", 4);
            dicoNonHDL.Add("4.0-4.9", 4);
            dicoNonHDL.Add("5.0-5.9", 5);
            dicoNonHDL.Add("6.0-6.9", 6);
            dicoTAS.Add("160-179", dicoNonHDL);

            dicoAge.Add("40-44", dicoTAS);

            //WOMAN SMOKING + 45-49
            dicoTAS = new Dictionary<string, Dictionary<string, int>>();

            dicoNonHDL = new Dictionary<string, int>();
            dicoNonHDL.Add("3.0-3.9", 2);
            dicoNonHDL.Add("4.0-4.9", 2);
            dicoNonHDL.Add("5.0-5.9", 3);
            dicoNonHDL.Add("6.0-6.9", 3);
            dicoTAS.Add("100-119", dicoNonHDL);

            dicoNonHDL = new Dictionary<string, int>();
            dicoNonHDL.Add("3.0-3.9", 3);
            dicoNonHDL.Add("4.0-4.9", 3);
            dicoNonHDL.Add("5.0-5.9", 4);
            dicoNonHDL.Add("6.0-6.9", 4);
            dicoTAS.Add("120-139", dicoNonHDL);

            dicoNonHDL = new Dictionary<string, int>();
            dicoNonHDL.Add("3.0-3.9", 4);
            dicoNonHDL.Add("4.0-4.9", 4);
            dicoNonHDL.Add("5.0-5.9", 5);
            dicoNonHDL.Add("6.0-6.9", 5);
            dicoTAS.Add("140-159", dicoNonHDL);

            dicoNonHDL = new Dictionary<string, int>();
            dicoNonHDL.Add("3.0-3.9", 5);
            dicoNonHDL.Add("4.0-4.9", 5);
            dicoNonHDL.Add("5.0-5.9", 6);
            dicoNonHDL.Add("6.0-6.9", 7);
            dicoTAS.Add("160-179", dicoNonHDL);

            dicoAge.Add("45-49", dicoTAS);

            //WOMAN SMOKING + 50-54
            dicoTAS = new Dictionary<string, Dictionary<string, int>>();

            dicoNonHDL = new Dictionary<string, int>();
            dicoNonHDL.Add("3.0-3.9", 3);
            dicoNonHDL.Add("4.0-4.9", 3);
            dicoNonHDL.Add("5.0-5.9", 4);
            dicoNonHDL.Add("6.0-6.9", 4);
            dicoTAS.Add("100-119", dicoNonHDL);

            dicoNonHDL = new Dictionary<string, int>();
            dicoNonHDL.Add("3.0-3.9", 4);
            dicoNonHDL.Add("4.0-4.9", 4);
            dicoNonHDL.Add("5.0-5.9", 5);
            dicoNonHDL.Add("6.0-6.9", 5);
            dicoTAS.Add("120-139", dicoNonHDL);

            dicoNonHDL = new Dictionary<string, int>();
            dicoNonHDL.Add("3.0-3.9", 5);
            dicoNonHDL.Add("4.0-4.9", 5);
            dicoNonHDL.Add("5.0-5.9", 6);
            dicoNonHDL.Add("6.0-6.9", 6);
            dicoTAS.Add("140-159", dicoNonHDL);

            dicoNonHDL = new Dictionary<string, int>();
            dicoNonHDL.Add("3.0-3.9", 6);
            dicoNonHDL.Add("4.0-4.9", 7);
            dicoNonHDL.Add("5.0-5.9", 7);
            dicoNonHDL.Add("6.0-6.9", 8);
            dicoTAS.Add("160-179", dicoNonHDL);

            dicoAge.Add("50-54", dicoTAS);

            //WOMAN SMOKING + 55-59
            dicoTAS = new Dictionary<string, Dictionary<string, int>>();

            dicoNonHDL = new Dictionary<string, int>();
            dicoNonHDL.Add("3.0-3.9", 4);
            dicoNonHDL.Add("4.0-4.9", 4);
            dicoNonHDL.Add("5.0-5.9", 5);
            dicoNonHDL.Add("6.0-6.9", 5);
            dicoTAS.Add("100-119", dicoNonHDL);

            dicoNonHDL = new Dictionary<string, int>();
            dicoNonHDL.Add("3.0-3.9", 5);
            dicoNonHDL.Add("4.0-4.9", 6);
            dicoNonHDL.Add("5.0-5.9", 6);
            dicoNonHDL.Add("6.0-6.9", 6);
            dicoTAS.Add("120-139", dicoNonHDL);

            dicoNonHDL = new Dictionary<string, int>();
            dicoNonHDL.Add("3.0-3.9", 6);
            dicoNonHDL.Add("4.0-4.9", 7);
            dicoNonHDL.Add("5.0-5.9", 7);
            dicoNonHDL.Add("6.0-6.9", 8);
            dicoTAS.Add("140-159", dicoNonHDL);

            dicoNonHDL = new Dictionary<string, int>();
            dicoNonHDL.Add("3.0-3.9", 8);
            dicoNonHDL.Add("4.0-4.9", 8);
            dicoNonHDL.Add("5.0-5.9", 9);
            dicoNonHDL.Add("6.0-6.9", 10);
            dicoTAS.Add("160-179", dicoNonHDL);

            dicoAge.Add("55-59", dicoTAS);



            //WOMAN SMOKING + 60-64
            dicoTAS = new Dictionary<string, Dictionary<string, int>>();

            dicoNonHDL = new Dictionary<string, int>();
            dicoNonHDL.Add("3.0-3.9", 5);
            dicoNonHDL.Add("4.0-4.9", 6);
            dicoNonHDL.Add("5.0-5.9", 6);
            dicoNonHDL.Add("6.0-6.9", 6);
            dicoTAS.Add("100-119", dicoNonHDL);

            dicoNonHDL = new Dictionary<string, int>();
            dicoNonHDL.Add("3.0-3.9", 6);
            dicoNonHDL.Add("4.0-4.9", 7);
            dicoNonHDL.Add("5.0-5.9", 7);
            dicoNonHDL.Add("6.0-6.9", 8);
            dicoTAS.Add("120-139", dicoNonHDL);

            dicoNonHDL = new Dictionary<string, int>();
            dicoNonHDL.Add("3.0-3.9", 8);
            dicoNonHDL.Add("4.0-4.9", 8);
            dicoNonHDL.Add("5.0-5.9", 9);
            dicoNonHDL.Add("6.0-6.9", 9);
            dicoTAS.Add("140-159", dicoNonHDL);

            dicoNonHDL = new Dictionary<string, int>();
            dicoNonHDL.Add("3.0-3.9", 10);
            dicoNonHDL.Add("4.0-4.9", 10);
            dicoNonHDL.Add("5.0-5.9", 11);
            dicoNonHDL.Add("6.0-6.9", 11);
            dicoTAS.Add("160-179", dicoNonHDL);

            dicoAge.Add("60-64", dicoTAS);

            //WOMAN SMOKING + 65-69
            dicoTAS = new Dictionary<string, Dictionary<string, int>>();

            dicoNonHDL = new Dictionary<string, int>();
            dicoNonHDL.Add("3.0-3.9", 7);
            dicoNonHDL.Add("4.0-4.9", 7);
            dicoNonHDL.Add("5.0-5.9", 7);
            dicoNonHDL.Add("6.0-6.9", 8);
            dicoTAS.Add("100-119", dicoNonHDL);

            dicoNonHDL = new Dictionary<string, int>();
            dicoNonHDL.Add("3.0-3.9", 8);
            dicoNonHDL.Add("4.0-4.9", 9);
            dicoNonHDL.Add("5.0-5.9", 9);
            dicoNonHDL.Add("6.0-6.9", 9);
            dicoTAS.Add("120-139", dicoNonHDL);

            dicoNonHDL = new Dictionary<string, int>();
            dicoNonHDL.Add("3.0-3.9", 10);
            dicoNonHDL.Add("4.0-4.9", 10);
            dicoNonHDL.Add("5.0-5.9", 11);
            dicoNonHDL.Add("6.0-6.9", 11);
            dicoTAS.Add("140-159", dicoNonHDL);

            dicoNonHDL = new Dictionary<string, int>();
            dicoNonHDL.Add("3.0-3.9", 12);
            dicoNonHDL.Add("4.0-4.9", 12);
            dicoNonHDL.Add("5.0-5.9", 13);
            dicoNonHDL.Add("6.0-6.9", 13);
            dicoTAS.Add("160-179", dicoNonHDL);

            dicoAge.Add("65-69", dicoTAS);

            //WOMAN SMOKING + 70-74
            dicoTAS = new Dictionary<string, Dictionary<string, int>>();

            dicoNonHDL = new Dictionary<string, int>();
            dicoNonHDL.Add("3.0-3.9", 9);
            dicoNonHDL.Add("4.0-4.9", 10);
            dicoNonHDL.Add("5.0-5.9", 10);
            dicoNonHDL.Add("6.0-6.9", 11);
            dicoTAS.Add("100-119", dicoNonHDL);

            dicoNonHDL = new Dictionary<string, int>();
            dicoNonHDL.Add("3.0-3.9", 11);
            dicoNonHDL.Add("4.0-4.9", 12);
            dicoNonHDL.Add("5.0-5.9", 13);
            dicoNonHDL.Add("6.0-6.9", 14);
            dicoTAS.Add("120-139", dicoNonHDL);

            dicoNonHDL = new Dictionary<string, int>();
            dicoNonHDL.Add("3.0-3.9", 14);
            dicoNonHDL.Add("4.0-4.9", 15);
            dicoNonHDL.Add("5.0-5.9", 16);
            dicoNonHDL.Add("6.0-6.9", 16);
            dicoTAS.Add("140-159", dicoNonHDL);

            dicoNonHDL = new Dictionary<string, int>();
            dicoNonHDL.Add("3.0-3.9", 17);
            dicoNonHDL.Add("4.0-4.9", 18);
            dicoNonHDL.Add("5.0-5.9", 19);
            dicoNonHDL.Add("6.0-6.9", 20);
            dicoTAS.Add("160-179", dicoNonHDL);

            dicoAge.Add("70-74", dicoTAS);

            //WOMAN SMOKING + 75-79
            dicoTAS = new Dictionary<string, Dictionary<string, int>>();

            dicoNonHDL = new Dictionary<string, int>();
            dicoNonHDL.Add("3.0-3.9", 13);
            dicoNonHDL.Add("4.0-4.9", 14);
            dicoNonHDL.Add("5.0-5.9", 15);
            dicoNonHDL.Add("6.0-6.9", 15);
            dicoTAS.Add("100-119", dicoNonHDL);

            dicoNonHDL = new Dictionary<string, int>();
            dicoNonHDL.Add("3.0-3.9", 15);
            dicoNonHDL.Add("4.0-4.9", 16);
            dicoNonHDL.Add("5.0-5.9", 17);
            dicoNonHDL.Add("6.0-6.9", 18);
            dicoTAS.Add("120-139", dicoNonHDL);

            dicoNonHDL = new Dictionary<string, int>();
            dicoNonHDL.Add("3.0-3.9", 18);
            dicoNonHDL.Add("4.0-4.9", 19);
            dicoNonHDL.Add("5.0-5.9", 20);
            dicoNonHDL.Add("6.0-6.9", 21);
            dicoTAS.Add("140-159", dicoNonHDL);

            dicoNonHDL = new Dictionary<string, int>();
            dicoNonHDL.Add("3.0-3.9", 21);
            dicoNonHDL.Add("4.0-4.9", 22);
            dicoNonHDL.Add("5.0-5.9", 23);
            dicoNonHDL.Add("6.0-6.9", 24);
            dicoTAS.Add("160-179", dicoNonHDL);

            dicoAge.Add("75-79", dicoTAS);

            //WOMAN SMOKING + 80-84
            dicoTAS = new Dictionary<string, Dictionary<string, int>>();

            dicoNonHDL = new Dictionary<string, int>();
            dicoNonHDL.Add("3.0-3.9", 18);
            dicoNonHDL.Add("4.0-4.9", 19);
            dicoNonHDL.Add("5.0-5.9", 20);
            dicoNonHDL.Add("6.0-6.9", 21);
            dicoTAS.Add("100-119", dicoNonHDL);

            dicoNonHDL = new Dictionary<string, int>();
            dicoNonHDL.Add("3.0-3.9", 20);
            dicoNonHDL.Add("4.0-4.9", 21);
            dicoNonHDL.Add("5.0-5.9", 22);
            dicoNonHDL.Add("6.0-6.9", 23);
            dicoTAS.Add("120-139", dicoNonHDL);

            dicoNonHDL = new Dictionary<string, int>();
            dicoNonHDL.Add("3.0-3.9", 23);
            dicoNonHDL.Add("4.0-4.9", 24);
            dicoNonHDL.Add("5.0-5.9", 25);
            dicoNonHDL.Add("6.0-6.9", 26);
            dicoTAS.Add("140-159", dicoNonHDL);

            dicoNonHDL = new Dictionary<string, int>();
            dicoNonHDL.Add("3.0-3.9", 25);
            dicoNonHDL.Add("4.0-4.9", 26);
            dicoNonHDL.Add("5.0-5.9", 28);
            dicoNonHDL.Add("6.0-6.9", 29);
            dicoTAS.Add("160-179", dicoNonHDL);

            dicoAge.Add("80-84", dicoTAS);


            //WOMAN SMOKING + 85-89
            dicoTAS = new Dictionary<string, Dictionary<string, int>>();

            dicoNonHDL = new Dictionary<string, int>();
            dicoNonHDL.Add("3.0-3.9", 25);
            dicoNonHDL.Add("4.0-4.9", 26);
            dicoNonHDL.Add("5.0-5.9", 27);
            dicoNonHDL.Add("6.0-6.9", 28);
            dicoTAS.Add("100-119", dicoNonHDL);

            dicoNonHDL = new Dictionary<string, int>();
            dicoNonHDL.Add("3.0-3.9", 27);
            dicoNonHDL.Add("4.0-4.9", 28);
            dicoNonHDL.Add("5.0-5.9", 29);
            dicoNonHDL.Add("6.0-6.9", 30);
            dicoTAS.Add("120-139", dicoNonHDL);

            dicoNonHDL = new Dictionary<string, int>();
            dicoNonHDL.Add("3.0-3.9", 29);
            dicoNonHDL.Add("4.0-4.9", 30);
            dicoNonHDL.Add("5.0-5.9", 31);
            dicoNonHDL.Add("6.0-6.9", 32);
            dicoTAS.Add("140-159", dicoNonHDL);

            dicoNonHDL = new Dictionary<string, int>();
            dicoNonHDL.Add("3.0-3.9", 31);
            dicoNonHDL.Add("4.0-4.9", 32);
            dicoNonHDL.Add("5.0-5.9", 33);
            dicoNonHDL.Add("6.0-6.9", 34);
            dicoTAS.Add("160-179", dicoNonHDL);

            dicoAge.Add("85-89", dicoTAS);

            dicoSMOKER.Add("SMOKER", dicoAge);
            SCORE2.Add("WOMAN", dicoSMOKER);
            dicoAge = new Dictionary<string, Dictionary<string, Dictionary<string, int>>>();
            dicoSMOKER = new Dictionary<string, Dictionary<string, Dictionary<string, Dictionary<string, int>>>>();
            #endregion "       SMOKING"
            /* ====================================================================== */


            #endregion "       WOMAN"
            /* ====================================================================== */

            /* ====================================================================== */
            #region "       MAN"
            /* ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~ */


            /* ====================================================================== */
            #region "       NON SMOKING"
            /* ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~ */
            //  

            dicoTAS = new Dictionary<string, Dictionary<string, int>>();

            //MAN NON SMOKING + 40-44
            dicoNonHDL = new Dictionary<string, int>();
            dicoNonHDL.Add("3.0-3.9", 1);
            dicoNonHDL.Add("4.0-4.9", 2);
            dicoNonHDL.Add("5.0-5.9", 2);
            dicoNonHDL.Add("6.0-6.9", 2);
            dicoTAS.Add("100-119", dicoNonHDL);

            dicoNonHDL = new Dictionary<string, int>();
            dicoNonHDL.Add("3.0-3.9", 2);
            dicoNonHDL.Add("4.0-4.9", 2);
            dicoNonHDL.Add("5.0-5.9", 3);
            dicoNonHDL.Add("6.0-6.9", 3);
            dicoTAS.Add("120-139", dicoNonHDL);

            dicoNonHDL = new Dictionary<string, int>();
            dicoNonHDL.Add("3.0-3.9", 2);
            dicoNonHDL.Add("4.0-4.9", 3);
            dicoNonHDL.Add("5.0-5.9", 3);
            dicoNonHDL.Add("6.0-6.9", 4);
            dicoTAS.Add("140-159", dicoNonHDL);

            dicoNonHDL = new Dictionary<string, int>();
            dicoNonHDL.Add("3.0-3.9", 3);
            dicoNonHDL.Add("4.0-4.9", 4);
            dicoNonHDL.Add("5.0-5.9", 5);
            dicoNonHDL.Add("6.0-6.9", 5);
            dicoTAS.Add("160-179", dicoNonHDL);

            dicoAge.Add("40-44", dicoTAS);

            //TODO t'en es ici frerito
            //MAN NON SMOKING + 45-49
            dicoTAS = new Dictionary<string, Dictionary<string, int>>();

            dicoNonHDL = new Dictionary<string, int>();
            dicoNonHDL.Add("3.0-3.9", 2);
            dicoNonHDL.Add("4.0-4.9", 2);
            dicoNonHDL.Add("5.0-5.9", 3);
            dicoNonHDL.Add("6.0-6.9", 3);
            dicoTAS.Add("100-119", dicoNonHDL);

            dicoNonHDL = new Dictionary<string, int>();
            dicoNonHDL.Add("3.0-3.9", 2);
            dicoNonHDL.Add("4.0-4.9", 3);
            dicoNonHDL.Add("5.0-5.9", 3);
            dicoNonHDL.Add("6.0-6.9", 4);
            dicoTAS.Add("120-139", dicoNonHDL);

            dicoNonHDL = new Dictionary<string, int>();
            dicoNonHDL.Add("3.0-3.9", 3);
            dicoNonHDL.Add("4.0-4.9", 4);
            dicoNonHDL.Add("5.0-5.9", 4);
            dicoNonHDL.Add("6.0-6.9", 5);
            dicoTAS.Add("140-159", dicoNonHDL);

            dicoNonHDL = new Dictionary<string, int>();
            dicoNonHDL.Add("3.0-3.9", 4);
            dicoNonHDL.Add("4.0-4.9", 5);
            dicoNonHDL.Add("5.0-5.9", 6);
            dicoNonHDL.Add("6.0-6.9", 6);
            dicoTAS.Add("160-179", dicoNonHDL);

            dicoAge.Add("45-49", dicoTAS);

            //MAN NON SMOKING + 50-54
            dicoTAS = new Dictionary<string, Dictionary<string, int>>();

            dicoNonHDL = new Dictionary<string, int>();
            dicoNonHDL.Add("3.0-3.9", 3);
            dicoNonHDL.Add("4.0-4.9", 3);
            dicoNonHDL.Add("5.0-5.9", 3);
            dicoNonHDL.Add("6.0-6.9", 4);
            dicoTAS.Add("100-119", dicoNonHDL);

            dicoNonHDL = new Dictionary<string, int>();
            dicoNonHDL.Add("3.0-3.9", 3);
            dicoNonHDL.Add("4.0-4.9", 4);
            dicoNonHDL.Add("5.0-5.9", 4);
            dicoNonHDL.Add("6.0-6.9", 5);
            dicoTAS.Add("120-139", dicoNonHDL);

            dicoNonHDL = new Dictionary<string, int>();
            dicoNonHDL.Add("3.0-3.9", 4);
            dicoNonHDL.Add("4.0-4.9", 5);
            dicoNonHDL.Add("5.0-5.9", 5);
            dicoNonHDL.Add("6.0-6.9", 6);
            dicoTAS.Add("140-159", dicoNonHDL);

            dicoNonHDL = new Dictionary<string, int>();
            dicoNonHDL.Add("3.0-3.9", 5);
            dicoNonHDL.Add("4.0-4.9", 6);
            dicoNonHDL.Add("5.0-5.9", 7);
            dicoNonHDL.Add("6.0-6.9", 8);
            dicoTAS.Add("160-179", dicoNonHDL);

            dicoAge.Add("50-54", dicoTAS);

            //MAN NON SMOKING + 55-59
            dicoTAS = new Dictionary<string, Dictionary<string, int>>();

            dicoNonHDL = new Dictionary<string, int>();
            dicoNonHDL.Add("3.0-3.9", 4);
            dicoNonHDL.Add("4.0-4.9", 4);
            dicoNonHDL.Add("5.0-5.9", 4);
            dicoNonHDL.Add("6.0-6.9", 5);
            dicoTAS.Add("100-119", dicoNonHDL);

            dicoNonHDL = new Dictionary<string, int>();
            dicoNonHDL.Add("3.0-3.9", 4);
            dicoNonHDL.Add("4.0-4.9", 5);
            dicoNonHDL.Add("5.0-5.9", 5);
            dicoNonHDL.Add("6.0-6.9", 6);
            dicoTAS.Add("120-139", dicoNonHDL);

            dicoNonHDL = new Dictionary<string, int>();
            dicoNonHDL.Add("3.0-3.9", 5);
            dicoNonHDL.Add("4.0-4.9", 6);
            dicoNonHDL.Add("5.0-5.9", 7);
            dicoNonHDL.Add("6.0-6.9", 8);
            dicoTAS.Add("140-159", dicoNonHDL);

            dicoNonHDL = new Dictionary<string, int>();
            dicoNonHDL.Add("3.0-3.9", 7);
            dicoNonHDL.Add("4.0-4.9", 7);
            dicoNonHDL.Add("5.0-5.9", 8);
            dicoNonHDL.Add("6.0-6.9", 9);
            dicoTAS.Add("160-179", dicoNonHDL);

            dicoAge.Add("55-59", dicoTAS);



            //MAN NON SMOKING + 60-64
            dicoTAS = new Dictionary<string, Dictionary<string, int>>();

            dicoNonHDL = new Dictionary<string, int>();
            dicoNonHDL.Add("3.0-3.9", 5);
            dicoNonHDL.Add("4.0-4.9", 5);
            dicoNonHDL.Add("5.0-5.9", 6);
            dicoNonHDL.Add("6.0-6.9", 6);
            dicoTAS.Add("100-119", dicoNonHDL);

            dicoNonHDL = new Dictionary<string, int>();
            dicoNonHDL.Add("3.0-3.9", 6);
            dicoNonHDL.Add("4.0-4.9", 6);
            dicoNonHDL.Add("5.0-5.9", 7);
            dicoNonHDL.Add("6.0-6.9", 8);
            dicoTAS.Add("120-139", dicoNonHDL);

            dicoNonHDL = new Dictionary<string, int>();
            dicoNonHDL.Add("3.0-3.9", 7);
            dicoNonHDL.Add("4.0-4.9", 8);
            dicoNonHDL.Add("5.0-5.9", 8);
            dicoNonHDL.Add("6.0-6.9", 9);
            dicoTAS.Add("140-159", dicoNonHDL);

            dicoNonHDL = new Dictionary<string, int>();
            dicoNonHDL.Add("3.0-3.9", 8);
            dicoNonHDL.Add("4.0-4.9", 9);
            dicoNonHDL.Add("5.0-5.9", 10);
            dicoNonHDL.Add("6.0-6.9", 11);
            dicoTAS.Add("160-179", dicoNonHDL);

            dicoAge.Add("60-64", dicoTAS);

            //MAN NON SMOKING + 65-69
            dicoTAS = new Dictionary<string, Dictionary<string, int>>();

            dicoNonHDL = new Dictionary<string, int>();
            dicoNonHDL.Add("3.0-3.9", 6);
            dicoNonHDL.Add("4.0-4.9", 7);
            dicoNonHDL.Add("5.0-5.9", 7);
            dicoNonHDL.Add("6.0-6.9", 8);
            dicoTAS.Add("100-119", dicoNonHDL);

            dicoNonHDL = new Dictionary<string, int>();
            dicoNonHDL.Add("3.0-3.9", 8);
            dicoNonHDL.Add("4.0-4.9", 8);
            dicoNonHDL.Add("5.0-5.9", 9);
            dicoNonHDL.Add("6.0-6.9", 10);
            dicoTAS.Add("120-139", dicoNonHDL);

            dicoNonHDL = new Dictionary<string, int>();
            dicoNonHDL.Add("3.0-3.9", 9);
            dicoNonHDL.Add("4.0-4.9", 10);
            dicoNonHDL.Add("5.0-5.9", 11);
            dicoNonHDL.Add("6.0-6.9", 11);
            dicoTAS.Add("140-159", dicoNonHDL);

            dicoNonHDL = new Dictionary<string, int>();
            dicoNonHDL.Add("3.0-3.9", 11);
            dicoNonHDL.Add("4.0-4.9", 12);
            dicoNonHDL.Add("5.0-5.9", 12);
            dicoNonHDL.Add("6.0-6.9", 13);
            dicoTAS.Add("160-179", dicoNonHDL);

            dicoAge.Add("65-69", dicoTAS);

            //MAN NON SMOKING + 70-74
            dicoTAS = new Dictionary<string, Dictionary<string, int>>();

            dicoNonHDL = new Dictionary<string, int>();
            dicoNonHDL.Add("3.0-3.9", 8);
            dicoNonHDL.Add("4.0-4.9", 8);
            dicoNonHDL.Add("5.0-5.9", 9);
            dicoNonHDL.Add("6.0-6.9", 10);
            dicoTAS.Add("100-119", dicoNonHDL);

            dicoNonHDL = new Dictionary<string, int>();
            dicoNonHDL.Add("3.0-3.9", 10);
            dicoNonHDL.Add("4.0-4.9", 11);
            dicoNonHDL.Add("5.0-5.9", 12);
            dicoNonHDL.Add("6.0-6.9", 13);
            dicoTAS.Add("120-139", dicoNonHDL);

            dicoNonHDL = new Dictionary<string, int>();
            dicoNonHDL.Add("3.0-3.9", 12);
            dicoNonHDL.Add("4.0-4.9", 13);
            dicoNonHDL.Add("5.0-5.9", 14);
            dicoNonHDL.Add("6.0-6.9", 16);
            dicoTAS.Add("140-159", dicoNonHDL);

            dicoNonHDL = new Dictionary<string, int>();
            dicoNonHDL.Add("3.0-3.9", 15);
            dicoNonHDL.Add("4.0-4.9", 16);
            dicoNonHDL.Add("5.0-5.9", 18);
            dicoNonHDL.Add("6.0-6.9", 19);
            dicoTAS.Add("160-179", dicoNonHDL);

            dicoAge.Add("70-74", dicoTAS);

            //MAN NON SMOKING + 75-79
            dicoTAS = new Dictionary<string, Dictionary<string, int>>();

            dicoNonHDL = new Dictionary<string, int>();
            dicoNonHDL.Add("3.0-3.9", 12);
            dicoNonHDL.Add("4.0-4.9", 13);
            dicoNonHDL.Add("5.0-5.9", 15);
            dicoNonHDL.Add("6.0-6.9", 17);
            dicoTAS.Add("100-119", dicoNonHDL);

            dicoNonHDL = new Dictionary<string, int>();
            dicoNonHDL.Add("3.0-3.9", 14);
            dicoNonHDL.Add("4.0-4.9", 15);
            dicoNonHDL.Add("5.0-5.9", 18);
            dicoNonHDL.Add("6.0-6.9", 20);
            dicoTAS.Add("120-139", dicoNonHDL);

            dicoNonHDL = new Dictionary<string, int>();
            dicoNonHDL.Add("3.0-3.9", 16);
            dicoNonHDL.Add("4.0-4.9", 18);
            dicoNonHDL.Add("5.0-5.9", 21);
            dicoNonHDL.Add("6.0-6.9", 23);
            dicoTAS.Add("140-159", dicoNonHDL);

            dicoNonHDL = new Dictionary<string, int>();
            dicoNonHDL.Add("3.0-3.9", 19);
            dicoNonHDL.Add("4.0-4.9", 21);
            dicoNonHDL.Add("5.0-5.9", 24);
            dicoNonHDL.Add("6.0-6.9", 27);
            dicoTAS.Add("160-179", dicoNonHDL);

            dicoAge.Add("75-79", dicoTAS);

            //MAN NON SMOKING + 80-84
            dicoTAS = new Dictionary<string, Dictionary<string, int>>();

            dicoNonHDL = new Dictionary<string, int>();
            dicoNonHDL.Add("3.0-3.9", 17);
            dicoNonHDL.Add("4.0-4.9", 20);
            dicoNonHDL.Add("5.0-5.9", 24);
            dicoNonHDL.Add("6.0-6.9", 28);
            dicoTAS.Add("100-119", dicoNonHDL);

            dicoNonHDL = new Dictionary<string, int>();
            dicoNonHDL.Add("3.0-3.9", 19);
            dicoNonHDL.Add("4.0-4.9", 22);
            dicoNonHDL.Add("5.0-5.9", 26);
            dicoNonHDL.Add("6.0-6.9", 31);
            dicoTAS.Add("120-139", dicoNonHDL);

            dicoNonHDL = new Dictionary<string, int>();
            dicoNonHDL.Add("3.0-3.9", 21);
            dicoNonHDL.Add("4.0-4.9", 25);
            dicoNonHDL.Add("5.0-5.9", 29);
            dicoNonHDL.Add("6.0-6.9", 34);
            dicoTAS.Add("140-159", dicoNonHDL);

            dicoNonHDL = new Dictionary<string, int>();
            dicoNonHDL.Add("3.0-3.9", 23);
            dicoNonHDL.Add("4.0-4.9", 27);
            dicoNonHDL.Add("5.0-5.9", 32);
            dicoNonHDL.Add("6.0-6.9", 37);
            dicoTAS.Add("160-179", dicoNonHDL);

            dicoAge.Add("80-84", dicoTAS);


            //MAN NON SMOKING + 85-89
            dicoTAS = new Dictionary<string, Dictionary<string, int>>();

            dicoNonHDL = new Dictionary<string, int>();
            dicoNonHDL.Add("3.0-3.9", 25);
            dicoNonHDL.Add("4.0-4.9", 30);
            dicoNonHDL.Add("5.0-5.9", 36);
            dicoNonHDL.Add("6.0-6.9", 43);
            dicoTAS.Add("100-119", dicoNonHDL);

            dicoNonHDL = new Dictionary<string, int>();
            dicoNonHDL.Add("3.0-3.9", 26);
            dicoNonHDL.Add("4.0-4.9", 32);
            dicoNonHDL.Add("5.0-5.9", 38);
            dicoNonHDL.Add("6.0-6.9", 45);
            dicoTAS.Add("120-139", dicoNonHDL);

            dicoNonHDL = new Dictionary<string, int>();
            dicoNonHDL.Add("3.0-3.9", 28);
            dicoNonHDL.Add("4.0-4.9", 33);
            dicoNonHDL.Add("5.0-5.9", 40);
            dicoNonHDL.Add("6.0-6.9", 47);
            dicoTAS.Add("140-159", dicoNonHDL);

            dicoNonHDL = new Dictionary<string, int>();
            dicoNonHDL.Add("3.0-3.9", 29);
            dicoNonHDL.Add("4.0-4.9", 35);
            dicoNonHDL.Add("5.0-5.9", 42);
            dicoNonHDL.Add("6.0-6.9", 49);
            dicoTAS.Add("160-179", dicoNonHDL);

            dicoAge.Add("85-89", dicoTAS);

            dicoSMOKER.Add("NON-SMOKER", dicoAge);
            dicoAge = new Dictionary<string, Dictionary<string, Dictionary<string, int>>>();
            #endregion "       NON SMOKING"
            /* ====================================================================== */

            //MAN SMOKING + 40-44
            dicoTAS = new Dictionary<string, Dictionary<string, int>>();
            dicoNonHDL = new Dictionary<string, int>();
            dicoNonHDL.Add("3.0-3.9", 3);
            dicoNonHDL.Add("4.0-4.9", 3);
            dicoNonHDL.Add("5.0-5.9", 4);
            dicoNonHDL.Add("6.0-6.9", 5);
            dicoTAS.Add("100-119", dicoNonHDL);

            dicoNonHDL = new Dictionary<string, int>();
            dicoNonHDL.Add("3.0-3.9", 3);
            dicoNonHDL.Add("4.0-4.9", 4);
            dicoNonHDL.Add("5.0-5.9", 5);
            dicoNonHDL.Add("6.0-6.9", 6);
            dicoTAS.Add("120-139", dicoNonHDL);

            dicoNonHDL = new Dictionary<string, int>();
            dicoNonHDL.Add("3.0-3.9", 5);
            dicoNonHDL.Add("4.0-4.9", 5);
            dicoNonHDL.Add("5.0-5.9", 6);
            dicoNonHDL.Add("6.0-6.9", 8);
            dicoTAS.Add("140-159", dicoNonHDL);

            dicoNonHDL = new Dictionary<string, int>();
            dicoNonHDL.Add("3.0-3.9", 6);
            dicoNonHDL.Add("4.0-4.9", 7);
            dicoNonHDL.Add("5.0-5.9", 8);
            dicoNonHDL.Add("6.0-6.9", 10);
            dicoTAS.Add("160-179", dicoNonHDL);

            dicoAge.Add("40-44", dicoTAS);

            //MAN SMOKING + 45-49
            dicoTAS = new Dictionary<string, Dictionary<string, int>>();

            dicoNonHDL = new Dictionary<string, int>();
            dicoNonHDL.Add("3.0-3.9", 3);
            dicoNonHDL.Add("4.0-4.9", 4);
            dicoNonHDL.Add("5.0-5.9", 5);
            dicoNonHDL.Add("6.0-6.9", 5);
            dicoTAS.Add("100-119", dicoNonHDL);

            dicoNonHDL = new Dictionary<string, int>();
            dicoNonHDL.Add("3.0-3.9", 4);
            dicoNonHDL.Add("4.0-4.9", 5);
            dicoNonHDL.Add("5.0-5.9", 6);
            dicoNonHDL.Add("6.0-6.9", 7);
            dicoTAS.Add("120-139", dicoNonHDL);

            dicoNonHDL = new Dictionary<string, int>();
            dicoNonHDL.Add("3.0-3.9", 6);
            dicoNonHDL.Add("4.0-4.9", 7);
            dicoNonHDL.Add("5.0-5.9", 8);
            dicoNonHDL.Add("6.0-6.9", 9);
            dicoTAS.Add("140-159", dicoNonHDL);

            dicoNonHDL = new Dictionary<string, int>();
            dicoNonHDL.Add("3.0-3.9", 7);
            dicoNonHDL.Add("4.0-4.9", 8);
            dicoNonHDL.Add("5.0-5.9", 10);
            dicoNonHDL.Add("6.0-6.9", 11);
            dicoTAS.Add("160-179", dicoNonHDL);

            dicoAge.Add("45-49", dicoTAS);

            //MAN SMOKING + 50-54
            dicoTAS = new Dictionary<string, Dictionary<string, int>>();

            dicoNonHDL = new Dictionary<string, int>();
            dicoNonHDL.Add("3.0-3.9", 4);
            dicoNonHDL.Add("4.0-4.9", 5);
            dicoNonHDL.Add("5.0-5.9", 6);
            dicoNonHDL.Add("6.0-6.9", 7);
            dicoTAS.Add("100-119", dicoNonHDL);

            dicoNonHDL = new Dictionary<string, int>();
            dicoNonHDL.Add("3.0-3.9", 6);
            dicoNonHDL.Add("4.0-4.9", 6);
            dicoNonHDL.Add("5.0-5.9", 7);
            dicoNonHDL.Add("6.0-6.9", 8);
            dicoTAS.Add("120-139", dicoNonHDL);

            dicoNonHDL = new Dictionary<string, int>();
            dicoNonHDL.Add("3.0-3.9", 7);
            dicoNonHDL.Add("4.0-4.9", 8);
            dicoNonHDL.Add("5.0-5.9", 9);
            dicoNonHDL.Add("6.0-6.9", 10);
            dicoTAS.Add("140-159", dicoNonHDL);

            dicoNonHDL = new Dictionary<string, int>();
            dicoNonHDL.Add("3.0-3.9", 9);
            dicoNonHDL.Add("4.0-4.9", 10);
            dicoNonHDL.Add("5.0-5.9", 11);
            dicoNonHDL.Add("6.0-6.9", 13);
            dicoTAS.Add("160-179", dicoNonHDL);

            dicoAge.Add("50-54", dicoTAS);

            //MAN SMOKING + 55-59
            dicoTAS = new Dictionary<string, Dictionary<string, int>>();

            dicoNonHDL = new Dictionary<string, int>();
            dicoNonHDL.Add("3.0-3.9", 6);
            dicoNonHDL.Add("4.0-4.9", 6);
            dicoNonHDL.Add("5.0-5.9", 7);
            dicoNonHDL.Add("6.0-6.9", 8);
            dicoTAS.Add("100-119", dicoNonHDL);

            dicoNonHDL = new Dictionary<string, int>();
            dicoNonHDL.Add("3.0-3.9", 7);
            dicoNonHDL.Add("4.0-4.9", 8);
            dicoNonHDL.Add("5.0-5.9", 9);
            dicoNonHDL.Add("6.0-6.9", 10);
            dicoTAS.Add("120-139", dicoNonHDL);

            dicoNonHDL = new Dictionary<string, int>();
            dicoNonHDL.Add("3.0-3.9", 9);
            dicoNonHDL.Add("4.0-4.9", 10);
            dicoNonHDL.Add("5.0-5.9", 11);
            dicoNonHDL.Add("6.0-6.9", 12);
            dicoTAS.Add("140-159", dicoNonHDL);

            dicoNonHDL = new Dictionary<string, int>();
            dicoNonHDL.Add("3.0-3.9", 10);
            dicoNonHDL.Add("4.0-4.9", 12);
            dicoNonHDL.Add("5.0-5.9", 13);
            dicoNonHDL.Add("6.0-6.9", 15);
            dicoTAS.Add("160-179", dicoNonHDL);

            dicoAge.Add("55-59", dicoTAS);



            //MAN SMOKING + 60-64
            dicoTAS = new Dictionary<string, Dictionary<string, int>>();

            dicoNonHDL = new Dictionary<string, int>();
            dicoNonHDL.Add("3.0-3.9", 7);
            dicoNonHDL.Add("4.0-4.9", 8);
            dicoNonHDL.Add("5.0-5.9", 9);
            dicoNonHDL.Add("6.0-6.9", 10);
            dicoTAS.Add("100-119", dicoNonHDL);

            dicoNonHDL = new Dictionary<string, int>();
            dicoNonHDL.Add("3.0-3.9", 9);
            dicoNonHDL.Add("4.0-4.9", 10);
            dicoNonHDL.Add("5.0-5.9", 10);
            dicoNonHDL.Add("6.0-6.9", 11);
            dicoTAS.Add("120-139", dicoNonHDL);

            dicoNonHDL = new Dictionary<string, int>();
            dicoNonHDL.Add("3.0-3.9", 10);
            dicoNonHDL.Add("4.0-4.9", 11);
            dicoNonHDL.Add("5.0-5.9", 13);
            dicoNonHDL.Add("6.0-6.9", 14);
            dicoTAS.Add("140-159", dicoNonHDL);

            dicoNonHDL = new Dictionary<string, int>();
            dicoNonHDL.Add("3.0-3.9", 13);
            dicoNonHDL.Add("4.0-4.9", 14);
            dicoNonHDL.Add("5.0-5.9", 15);
            dicoNonHDL.Add("6.0-6.9", 17);
            dicoTAS.Add("160-179", dicoNonHDL);

            dicoAge.Add("60-64", dicoTAS);

            //MAN SMOKING + 65-69
            dicoTAS = new Dictionary<string, Dictionary<string, int>>();

            dicoNonHDL = new Dictionary<string, int>();
            dicoNonHDL.Add("3.0-3.9", 9);
            dicoNonHDL.Add("4.0-4.9", 10);
            dicoNonHDL.Add("5.0-5.9", 11);
            dicoNonHDL.Add("6.0-6.9", 11);
            dicoTAS.Add("100-119", dicoNonHDL);

            dicoNonHDL = new Dictionary<string, int>();
            dicoNonHDL.Add("3.0-3.9", 11);
            dicoNonHDL.Add("4.0-4.9", 12);
            dicoNonHDL.Add("5.0-5.9", 13);
            dicoNonHDL.Add("6.0-6.9", 13);
            dicoTAS.Add("120-139", dicoNonHDL);

            dicoNonHDL = new Dictionary<string, int>();
            dicoNonHDL.Add("3.0-3.9", 13);
            dicoNonHDL.Add("4.0-4.9", 14);
            dicoNonHDL.Add("5.0-5.9", 15);
            dicoNonHDL.Add("6.0-6.9", 16);
            dicoTAS.Add("140-159", dicoNonHDL);

            dicoNonHDL = new Dictionary<string, int>();
            dicoNonHDL.Add("3.0-3.9", 15);
            dicoNonHDL.Add("4.0-4.9", 16);
            dicoNonHDL.Add("5.0-5.9", 17);
            dicoNonHDL.Add("6.0-6.9", 19);
            dicoTAS.Add("160-179", dicoNonHDL);

            dicoAge.Add("65-69", dicoTAS);

            //MAN SMOKING + 70-74
            dicoTAS = new Dictionary<string, Dictionary<string, int>>();

            dicoNonHDL = new Dictionary<string, int>();
            dicoNonHDL.Add("3.0-3.9", 12);
            dicoNonHDL.Add("4.0-4.9", 13);
            dicoNonHDL.Add("5.0-5.9", 14);
            dicoNonHDL.Add("6.0-6.9", 15);
            dicoTAS.Add("100-119", dicoNonHDL);

            dicoNonHDL = new Dictionary<string, int>();
            dicoNonHDL.Add("3.0-3.9", 14);
            dicoNonHDL.Add("4.0-4.9", 16);
            dicoNonHDL.Add("5.0-5.9", 17);
            dicoNonHDL.Add("6.0-6.9", 19);
            dicoTAS.Add("120-139", dicoNonHDL);

            dicoNonHDL = new Dictionary<string, int>();
            dicoNonHDL.Add("3.0-3.9", 18);
            dicoNonHDL.Add("4.0-4.9", 19);
            dicoNonHDL.Add("5.0-5.9", 21);
            dicoNonHDL.Add("6.0-6.9", 23);
            dicoTAS.Add("140-159", dicoNonHDL);

            dicoNonHDL = new Dictionary<string, int>();
            dicoNonHDL.Add("3.0-3.9", 22);
            dicoNonHDL.Add("4.0-4.9", 24);
            dicoNonHDL.Add("5.0-5.9", 26);
            dicoNonHDL.Add("6.0-6.9", 28);
            dicoTAS.Add("160-179", dicoNonHDL);

            dicoAge.Add("70-74", dicoTAS);

            //MAN SMOKING + 75-79
            dicoTAS = new Dictionary<string, Dictionary<string, int>>();

            dicoNonHDL = new Dictionary<string, int>();
            dicoNonHDL.Add("3.0-3.9", 15);
            dicoNonHDL.Add("4.0-4.9", 17);
            dicoNonHDL.Add("5.0-5.9", 19);
            dicoNonHDL.Add("6.0-6.9", 22);
            dicoTAS.Add("100-119", dicoNonHDL);

            dicoNonHDL = new Dictionary<string, int>();
            dicoNonHDL.Add("3.0-3.9", 18);
            dicoNonHDL.Add("4.0-4.9", 20);
            dicoNonHDL.Add("5.0-5.9", 23);
            dicoNonHDL.Add("6.0-6.9", 26);
            dicoTAS.Add("120-139", dicoNonHDL);

            dicoNonHDL = new Dictionary<string, int>();
            dicoNonHDL.Add("3.0-3.9", 21);
            dicoNonHDL.Add("4.0-4.9", 23);
            dicoNonHDL.Add("5.0-5.9", 26);
            dicoNonHDL.Add("6.0-6.9", 30);
            dicoTAS.Add("140-159", dicoNonHDL);

            dicoNonHDL = new Dictionary<string, int>();
            dicoNonHDL.Add("3.0-3.9", 24);
            dicoNonHDL.Add("4.0-4.9", 27);
            dicoNonHDL.Add("5.0-5.9", 31);
            dicoNonHDL.Add("6.0-6.9", 34);
            dicoTAS.Add("160-179", dicoNonHDL);

            dicoAge.Add("75-79", dicoTAS);

            //MAN SMOKING + 80-84
            dicoTAS = new Dictionary<string, Dictionary<string, int>>();

            dicoNonHDL = new Dictionary<string, int>();
            dicoNonHDL.Add("3.0-3.9", 19);
            dicoNonHDL.Add("4.0-4.9", 23);
            dicoNonHDL.Add("5.0-5.9", 27);
            dicoNonHDL.Add("6.0-6.9", 31);
            dicoTAS.Add("100-119", dicoNonHDL);

            dicoNonHDL = new Dictionary<string, int>();
            dicoNonHDL.Add("3.0-3.9", 22);
            dicoNonHDL.Add("4.0-4.9", 25);
            dicoNonHDL.Add("5.0-5.9", 30);
            dicoNonHDL.Add("6.0-6.9", 34);
            dicoTAS.Add("120-139", dicoNonHDL);

            dicoNonHDL = new Dictionary<string, int>();
            dicoNonHDL.Add("3.0-3.9", 24);
            dicoNonHDL.Add("4.0-4.9", 28);
            dicoNonHDL.Add("5.0-5.9", 33);
            dicoNonHDL.Add("6.0-6.9", 38);
            dicoTAS.Add("140-159", dicoNonHDL);

            dicoNonHDL = new Dictionary<string, int>();
            dicoNonHDL.Add("3.0-3.9", 26);
            dicoNonHDL.Add("4.0-4.9", 31);
            dicoNonHDL.Add("5.0-5.9", 36);
            dicoNonHDL.Add("6.0-6.9", 41);
            dicoTAS.Add("160-179", dicoNonHDL);

            dicoAge.Add("80-84", dicoTAS);


            //MAN SMOKING + 85-89
            dicoTAS = new Dictionary<string, Dictionary<string, int>>();

            dicoNonHDL = new Dictionary<string, int>();
            dicoNonHDL.Add("3.0-3.9", 25);
            dicoNonHDL.Add("4.0-4.9", 30);
            dicoNonHDL.Add("5.0-5.9", 36);
            dicoNonHDL.Add("6.0-6.9", 43);
            dicoTAS.Add("100-119", dicoNonHDL);

            dicoNonHDL = new Dictionary<string, int>();
            dicoNonHDL.Add("3.0-3.9", 26);
            dicoNonHDL.Add("4.0-4.9", 32);
            dicoNonHDL.Add("5.0-5.9", 38);
            dicoNonHDL.Add("6.0-6.9", 45);
            dicoTAS.Add("120-139", dicoNonHDL);

            dicoNonHDL = new Dictionary<string, int>();
            dicoNonHDL.Add("3.0-3.9", 27);
            dicoNonHDL.Add("4.0-4.9", 33);
            dicoNonHDL.Add("5.0-5.9", 40);
            dicoNonHDL.Add("6.0-6.9", 47);
            dicoTAS.Add("140-159", dicoNonHDL);

            dicoNonHDL = new Dictionary<string, int>();
            dicoNonHDL.Add("3.0-3.9", 29);
            dicoNonHDL.Add("4.0-4.9", 35);
            dicoNonHDL.Add("5.0-5.9", 42);
            dicoNonHDL.Add("6.0-6.9", 49);
            dicoTAS.Add("160-179", dicoNonHDL);

            dicoAge.Add("85-89", dicoTAS);

            dicoSMOKER.Add("SMOKER", dicoAge);
            SCORE2.Add("MAN", dicoSMOKER);

            #endregion "       MAN"
            /* ====================================================================== */
        }


        public int calculateSCORE2CVD(int Sexe, int Tabac, int cAge, int cPAS, float cCT)
        {
         

            string AgeKey = "";
            string SexKey = "";
            string TabacKey = "";
            string PASKey = "";
            string cCTKey = "";

            //if(cAge >= 40 && cAge <= 49) AgeArrondi = 40;
            // [fsb] les plus jeunes ont droit à un SCORE2 à 0 et pas NA
            if (cAge < 40) return -1;
            if (cAge <= 49) AgeKey = "40-44";
            if (cAge >= 50 && cAge <= 54) AgeKey = "50-54";
            if (cAge >= 55 && cAge <= 59) AgeKey = "55-59";
            if (cAge >= 60 && cAge <= 64) AgeKey = "60-64";
            if (cAge >= 65 && cAge <= 69) AgeKey = "65-69";
            if (cAge >= 70 && cAge <= 74) AgeKey = "70-74";
            if (cAge >= 75 && cAge <= 79) AgeKey = "75-79";
            if (cAge >= 80 && cAge <= 84) AgeKey = "80-84";
            if (cAge >= 84) AgeKey = "85-89";

            if (Sexe == 1) SexKey = "MAN";
            if (Sexe == 2) SexKey = "WOMAN";

            if (Tabac == 1) TabacKey = "SMOKER";
            if (Tabac == 0) TabacKey = "NON-SMOKER";

            if (cCT >= 3 && cCT < 4) cCTKey = "3.0-3.9";
            if (cCT >= 4 && cCT < 5) cCTKey = "4.0-4.9";
            if (cCT >= 5 && cCT < 6) cCTKey = "5.0-5.9";
            if (cCT >= 6 && cCT < 7) cCTKey = "6.0-6.9";
            if (cCT >= 7) cCTKey = "6.0-6.9";

            if (cPAS < 100) return -1;
            if (cPAS >= 100 && cPAS <= 119) PASKey = "100-119";
            if (cPAS >= 120 && cPAS <= 139) PASKey = "120-139";
            if (cPAS >= 140 && cPAS <= 159) PASKey = "140-159";
            if (cPAS >= 160 && cPAS <= 179) PASKey = "160-179";
            if (cPAS > 179) PASKey = "160-179";

            try
            {
                var dicoSexResult = SCORE2[SexKey];
                var dicoTabacResult = dicoSexResult[TabacKey];
                var dicoAgeResult = dicoTabacResult[AgeKey];
                var dicoTASResult = dicoAgeResult[PASKey];
                int result = dicoTASResult[cCTKey];

                return result;
            }
            catch (Exception e)
            {
                return 0;
            }
            
        }

        public Color getColorFromSCORE2(int SCORE2CVD, int age)
        {
            try
            {
                if (age < 50)
                {
                    if (SCORE2CVD < 3) return Color.FromArgb(255, 80, 191, 144);
                    if (SCORE2CVD >= 3 && SCORE2CVD < 7) return Color.FromArgb(255, 245, 147, 35);
                    if (SCORE2CVD >= 7) return Color.FromArgb(255, 176, 26, 45);
                }
                else if(age >= 50 && age <= 69)
                {
                    if (SCORE2CVD < 5) return Color.FromArgb(255, 80, 191, 144);
                    if (SCORE2CVD >= 5 && SCORE2CVD < 10) return Color.FromArgb(255, 245, 147, 35);
                    if (SCORE2CVD >= 10) return Color.FromArgb(255, 176, 26, 45);
                }
                else if(age >= 70)
                {
                    if (SCORE2CVD < 7) return Color.FromArgb(255, 80, 191, 144);
                    if (SCORE2CVD >= 8 && SCORE2CVD < 15) return Color.FromArgb(255, 245, 147, 35);
                    if (SCORE2CVD >= 15) return Color.FromArgb(255, 176, 26, 45);
                }
            }
            catch (Exception e)
            {
                return Color.White;
            }
            return Color.White;
        }
    }
}
