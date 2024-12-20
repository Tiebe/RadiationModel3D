using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Phosphorus27 : RadioactiveSubstance
    {
        public override string name { get; } = "Phosphorus27";
        public override double halfLife { get; } = 0.26d;
        public override double atomicWeight { get; } = 26.99929d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {
            { 1.0d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Aluminum27()), new(1.0d, new BetaParticle(1, betaPlusSpectrum)) } },
            { 0.0007000000000000001d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Aluminum26()), new(1.0d, new BetaParticle(1, betaPlusSpectrum)), new(1.0d, new ProtonParticle()) } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {
            { 0.0d, 0d },
            { 5000.0d, 0.000000267804d },
            { 10000.0d, 0.000000573583d },
            { 15000.0d, 0.000000916888d },
            { 20000.0d, 0.00000129579d },
            { 25000.0d, 0.00000171044d },
            { 30000.0d, 0.00000210088d },
            { 35000.0d, 0.0000024724d },
            { 40000.0d, 0.00000283559d },
            { 45000.0d, 0.00000319059d },
            { 50000.0d, 0.00000353735d },
            { 55000.0d, 0.00000387775d },
            { 60000.0d, 0.00000421271d },
            { 65000.0d, 0.00000454141d },
            { 70000.0d, 0.00000486666d },
            { 75000.0d, 0.00000518721d },
            { 80000.0d, 0.00000550376d },
            { 85000.0d, 0.00000581745d },
            { 90000.0d, 0.0000061276d },
            { 95000.0d, 0.00000643533d },
            { 100000.0d, 0.00000674054d },
            { 110000.0d, 0.00000734424d },
            { 120000.0d, 0.00000794041d },
            { 130000.0d, 0.00000853039d },
            { 140000.0d, 0.00000911537d },
            { 150000.0d, 0.00000969592d },
            { 160000.0d, 0.0000102728d },
            { 170000.0d, 0.0000108466d },
            { 180000.0d, 0.0000114178d },
            { 190000.0d, 0.0000119868d },
            { 200000.0d, 0.0000125539d },
            { 210000.0d, 0.0000131194d },
            { 220000.0d, 0.0000136835d },
            { 230000.0d, 0.0000142464d },
            { 240000.0d, 0.0000148082d },
            { 250000.0d, 0.0000153691d },
            { 260000.0d, 0.0000159292d },
            { 270000.0d, 0.0000164885d },
            { 280000.0d, 0.0000170472d },
            { 290000.0d, 0.0000176052d },
            { 300000.0d, 0.0000181625d },
            { 310000.0d, 0.0000187194d },
            { 320000.0d, 0.0000192756d },
            { 330000.0d, 0.0000198313d },
            { 340000.0d, 0.0000203864d },
            { 350000.0d, 0.0000209409d },
            { 360000.0d, 0.0000214948d },
            { 370000.0d, 0.000022048d },
            { 380000.0d, 0.0000226006d },
            { 390000.0d, 0.0000231525d },
            { 400000.0d, 0.0000237037d },
            { 410000.0d, 0.000024254d },
            { 420000.0d, 0.0000248036d },
            { 430000.0d, 0.0000253524d },
            { 440000.0d, 0.0000259001d },
            { 450000.0d, 0.000026447d },
            { 460000.0d, 0.0000269928d },
            { 470000.0d, 0.0000275374d },
            { 480000.0d, 0.0000280811d },
            { 490000.0d, 0.0000286235d },
            { 500000.0d, 0.0000291647d },
            { 510000.0d, 0.0000297046d },
            { 520000.0d, 0.0000302431d },
            { 530000.0d, 0.0000307802d },
            { 540000.0d, 0.0000313158d },
            { 550000.0d, 0.0000318499d },
            { 560000.0d, 0.0000323823d },
            { 570000.0d, 0.0000329131d },
            { 580000.0d, 0.0000334421d },
            { 590000.0d, 0.0000339694d },
            { 600000.0d, 0.0000344948d },
            { 610000.0d, 0.0000350183d },
            { 620000.0d, 0.0000355397d },
            { 630000.0d, 0.0000360592d },
            { 640000.0d, 0.0000365766d },
            { 650000.0d, 0.0000370918d },
            { 660000.0d, 0.0000376047d },
            { 670000.0d, 0.0000381153d },
            { 680000.0d, 0.0000386236d },
            { 690000.0d, 0.0000391294d },
            { 700000.0d, 0.0000396328d },
            { 710000.0d, 0.0000401337d },
            { 720000.0d, 0.0000406319d },
            { 730000.0d, 0.0000411275d },
            { 740000.0d, 0.0000416204d },
            { 750000.0d, 0.0000421104d },
            { 760000.0d, 0.0000425976d },
            { 770000.0d, 0.000043082d },
            { 780000.0d, 0.0000435633d },
            { 790000.0d, 0.0000440416d },
            { 800000.0d, 0.0000445169d },
            { 810000.0d, 0.0000449891d },
            { 820000.0d, 0.0000454581d },
            { 830000.0d, 0.0000459238d },
            { 840000.0d, 0.0000463862d },
            { 850000.0d, 0.0000468452d },
            { 860000.0d, 0.0000473009d },
            { 870000.0d, 0.000047753d },
            { 880000.0d, 0.0000482018d },
            { 890000.0d, 0.0000486469d },
            { 900000.0d, 0.0000490884d },
            { 910000.0d, 0.0000495262d },
            { 920000.0d, 0.0000499603d },
            { 930000.0d, 0.0000503907d },
            { 940000.0d, 0.0000508172d },
            { 950000.0d, 0.0000512398d },
            { 960000.0d, 0.0000516585d },
            { 970000.0d, 0.0000520733d },
            { 980000.0d, 0.000052484d },
            { 990000.0d, 0.0000528908d },
            { 1000000.0d, 0.0000532934d },
            { 1013000.0d, 0.0000538105d },
            { 1026000.0d, 0.0000543206d },
            { 1039000.0d, 0.0000548234d },
            { 1052000.0d, 0.000055319d },
            { 1065000.0d, 0.0000558072d },
            { 1078000.0d, 0.0000562879d },
            { 1091000.0d, 0.000056761d },
            { 1104000.0d, 0.0000572264d },
            { 1117000.0d, 0.0000576842d },
            { 1130000.0d, 0.000058134d },
            { 1143000.0d, 0.000058576d },
            { 1156000.0d, 0.00005901d },
            { 1169000.0d, 0.0000594359d },
            { 1182000.0d, 0.0000598538d },
            { 1195000.0d, 0.0000602633d },
            { 1208000.0d, 0.0000606646d },
            { 1221000.0d, 0.0000610576d },
            { 1234000.0d, 0.0000614421d },
            { 1247000.0d, 0.0000618183d },
            { 1260000.0d, 0.0000621857d },
            { 1273000.0d, 0.0000625447d },
            { 1286000.0d, 0.0000628949d },
            { 1299000.0d, 0.0000632364d },
            { 1312000.0d, 0.0000635691d },
            { 1325000.0d, 0.000063893d },
            { 1338000.0d, 0.000064208d },
            { 1351000.0d, 0.000064514d },
            { 1364000.0d, 0.0000648111d },
            { 1377000.0d, 0.0000650992d },
            { 1390000.0d, 0.0000653781d },
            { 1403000.0d, 0.000065648d },
            { 1416000.0d, 0.0000659086d },
            { 1429000.0d, 0.0000661601d },
            { 1442000.0d, 0.0000664024d },
            { 1455000.0d, 0.0000666354d },
            { 1468000.0d, 0.0000668591d },
            { 1481000.0d, 0.0000670734d },
            { 1494000.0d, 0.0000672784d },
            { 1507000.0d, 0.0000674739d },
            { 1520000.0d, 0.00006766d },
            { 1533000.0d, 0.0000678369d },
            { 1546000.0d, 0.0000680041d },
            { 1559000.0d, 0.0000681619d },
            { 1572000.0d, 0.0000683102d },
            { 1585000.0d, 0.000068449d },
            { 1598000.0d, 0.0000685782d },
            { 1611000.0d, 0.0000686979d },
            { 1624000.0d, 0.000068808d },
            { 1637000.0d, 0.0000689085d },
            { 1650000.0d, 0.0000689994d },
            { 1663000.0d, 0.0000690807d },
            { 1676000.0d, 0.0000691524d },
            { 1689000.0d, 0.0000692146d },
            { 1702000.0d, 0.000069267d },
            { 1715000.0d, 0.0000693099d },
            { 1728000.0d, 0.0000693432d },
            { 1741000.0d, 0.000069367d },
            { 1754000.0d, 0.0000693811d },
            { 1767000.0d, 0.0000693857d },
            { 1780000.0d, 0.0000693807d },
            { 1793000.0d, 0.0000693662d },
            { 1806000.0d, 0.0000693422d },
            { 1819000.0d, 0.0000693086d },
            { 1832000.0d, 0.0000692656d },
            { 1845000.0d, 0.0000692131d },
            { 1858000.0d, 0.0000691511d },
            { 1871000.0d, 0.0000690798d },
            { 1884000.0d, 0.0000689991d },
            { 1897000.0d, 0.000068909d },
            { 1910000.0d, 0.0000688096d },
            { 1923000.0d, 0.0000687009d },
            { 1936000.0d, 0.000068583d },
            { 1949000.0d, 0.0000684559d },
            { 1962000.0d, 0.0000683195d },
            { 1975000.0d, 0.000068174d },
            { 1988000.0d, 0.0000680194d },
            { 2001000.0d, 0.0000678558d },
            { 2014000.0d, 0.0000676833d },
            { 2027000.0d, 0.0000675017d },
            { 2040000.0d, 0.0000673113d },
            { 2053000.0d, 0.000067112d },
            { 2066000.0d, 0.000066904d },
            { 2079000.0d, 0.0000666872d },
            { 2092000.0d, 0.0000664617d },
            { 2105000.0d, 0.0000662277d },
            { 2118000.0d, 0.000065985d },
            { 2131000.0d, 0.0000657339d },
            { 2144000.0d, 0.0000654743d },
            { 2157000.0d, 0.0000652064d },
            { 2170000.0d, 0.0000649303d },
            { 2183000.0d, 0.0000646459d },
            { 2196000.0d, 0.0000643535d },
            { 2209000.0d, 0.0000640528d },
            { 2222000.0d, 0.000063744d },
            { 2235000.0d, 0.000063427d },
            { 2248000.0d, 0.000063102d },
            { 2261000.0d, 0.0000627691d },
            { 2274000.0d, 0.0000624282d },
            { 2287000.0d, 0.0000620796d },
            { 2300000.0d, 0.0000617233d },
            { 2313000.0d, 0.0000613594d },
            { 2326000.0d, 0.0000609878d },
            { 2339000.0d, 0.0000606088d },
            { 2352000.0d, 0.0000602221d },
            { 2365000.0d, 0.000059828d },
            { 2378000.0d, 0.0000594266d },
            { 2391000.0d, 0.0000590179d },
            { 2404000.0d, 0.000058602d },
            { 2417000.0d, 0.0000581791d },
            { 2430000.0d, 0.0000577492d },
            { 2443000.0d, 0.0000573124d },
            { 2456000.0d, 0.0000568688d },
            { 2469000.0d, 0.0000564186d },
            { 2482000.0d, 0.0000559617d },
            { 2495000.0d, 0.0000554985d },
            { 2508000.0d, 0.0000550288d },
            { 2521000.0d, 0.0000545529d },
            { 2534000.0d, 0.0000540708d },
            { 2547000.0d, 0.0000535827d },
            { 2560000.0d, 0.0000530886d },
            { 2573000.0d, 0.0000525889d },
            { 2586000.0d, 0.0000520833d },
            { 2599000.0d, 0.0000515722d },
            { 2612000.0d, 0.0000510558d },
            { 2625000.0d, 0.0000505339d },
            { 2638000.0d, 0.0000500069d },
            { 2651000.0d, 0.0000494747d },
            { 2664000.0d, 0.0000489376d },
            { 2677000.0d, 0.0000483958d },
            { 2690000.0d, 0.0000478492d },
            { 2703000.0d, 0.0000472982d },
            { 2716000.0d, 0.0000467427d },
            { 2729000.0d, 0.0000461829d },
            { 2742000.0d, 0.000045619d },
            { 2755000.0d, 0.0000450511d },
            { 2768000.0d, 0.0000444794d },
            { 2781000.0d, 0.000043904d },
            { 2794000.0d, 0.0000433251d },
            { 2807000.0d, 0.0000427427d },
            { 2820000.0d, 0.0000421571d },
            { 2833000.0d, 0.0000415684d },
            { 2846000.0d, 0.0000409767d },
            { 2859000.0d, 0.0000403822d },
            { 2872000.0d, 0.0000397851d },
            { 2885000.0d, 0.0000391856d },
            { 2898000.0d, 0.0000385837d },
            { 2911000.0d, 0.0000379797d },
            { 2924000.0d, 0.0000373737d },
            { 2937000.0d, 0.0000367658d },
            { 2950000.0d, 0.0000361563d },
            { 2963000.0d, 0.0000355454d },
            { 2976000.0d, 0.0000349331d },
            { 2989000.0d, 0.0000343196d },
            { 3002000.0d, 0.0000337052d },
            { 3015000.0d, 0.00003309d },
            { 3028000.0d, 0.0000324743d },
            { 3041000.0d, 0.000031858d },
            { 3054000.0d, 0.0000312416d },
            { 3067000.0d, 0.000030625d },
            { 3080000.0d, 0.0000300086d },
            { 3093000.0d, 0.0000293926d },
            { 3106000.0d, 0.0000287769d },
            { 3119000.0d, 0.0000281621d },
            { 3132000.0d, 0.000027548d },
            { 3145000.0d, 0.000026935d },
            { 3158000.0d, 0.0000263234d },
            { 3171000.0d, 0.0000257132d },
            { 3184000.0d, 0.0000251046d },
            { 3197000.0d, 0.0000244979d },
            { 3210000.0d, 0.0000238933d },
            { 3223000.0d, 0.0000232909d },
            { 3236000.0d, 0.0000226911d },
            { 3249000.0d, 0.0000220939d },
            { 3262000.0d, 0.0000214997d },
            { 3275000.0d, 0.0000209085d },
            { 3288000.0d, 0.0000203207d },
            { 3301000.0d, 0.0000197363d },
            { 3314000.0d, 0.0000191558d },
            { 3327000.0d, 0.0000185792d },
            { 3340000.0d, 0.0000180068d },
            { 3353000.0d, 0.0000174388d },
            { 3366000.0d, 0.0000168754d },
            { 3379000.0d, 0.000016317d },
            { 3392000.0d, 0.0000157636d },
            { 3405000.0d, 0.0000152154d },
            { 3418000.0d, 0.0000146729d },
            { 3431000.0d, 0.0000141361d },
            { 3444000.0d, 0.0000136053d },
            { 3457000.0d, 0.0000130808d },
            { 3470000.0d, 0.0000125627d },
            { 3483000.0d, 0.0000120514d },
            { 3496000.0d, 0.0000115469d },
            { 3509000.0d, 0.0000110497d },
            { 3522000.0d, 0.00001056d },
            { 3535000.0d, 0.0000100779d },
            { 3548000.0d, 0.00000960369d },
            { 3561000.0d, 0.00000913769d },
            { 3574000.0d, 0.00000868011d },
            { 3587000.0d, 0.00000823121d },
            { 3600000.0d, 0.00000779122d },
            { 3613000.0d, 0.00000736042d },
            { 3626000.0d, 0.00000693904d },
            { 3639000.0d, 0.00000652736d },
            { 3652000.0d, 0.00000612562d },
            { 3665000.0d, 0.00000573408d },
            { 3678000.0d, 0.00000535302d },
            { 3691000.0d, 0.00000498267d },
            { 3704000.0d, 0.00000462332d },
            { 3717000.0d, 0.00000427523d },
            { 3730000.0d, 0.00000393865d },
            { 3743000.0d, 0.00000361387d },
            { 3756000.0d, 0.00000330115d },
            { 3769000.0d, 0.00000300076d },
            { 3782000.0d, 0.00000271296d },
            { 3795000.0d, 0.00000243804d },
            { 3808000.0d, 0.00000217627d },
            { 3821000.0d, 0.00000192792d },
            { 3834000.0d, 0.00000169326d },
            { 3847000.0d, 0.00000147258d },
            { 3860000.0d, 0.00000126615d },
            { 3873000.0d, 0.00000107424d },
            { 3886000.0d, 0.000000897135d },
            { 3899000.0d, 0.000000735116d },
            { 3912000.0d, 0.000000588457d },
            { 3925000.0d, 0.000000457434d },
            { 3938000.0d, 0.000000342326d },
            { 3951000.0d, 0.000000243406d },
            { 3964000.0d, 0.000000160945d },
            { 3977000.0d, 0.000000095209d },
            { 3990000.0d, 0.0000000464557d },
            { 4003000.0d, 0.0000000149265d },
            { 4016000.0d, 0.000000000822065d },
            { 4020000.0d, 0d },

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    