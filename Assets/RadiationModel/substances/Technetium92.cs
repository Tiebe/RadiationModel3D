using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Technetium92 : RadioactiveSubstance
    {
        public override string name { get; } = "Technetium92";
        public override double halfLife { get; } = 255.0d;
        public override double atomicWeight { get; } = 91.91527d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {
            { 1.0d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Niobium92()), new(1.0d, new BetaParticle(1, betaPlusSpectrum)), new(0.12082696999999999d, new GammaParticle(85000.0, 0.01459)), new(0.7089847d, new GammaParticle(148000.0, 0.00838)), new(0.13280981d, new GammaParticle(243700.0, 0.00509)), new(0.79785743d, new GammaParticle(329300.0, 0.00377)), new(0.99857d, new GammaParticle(773000.0, 0.0016)), new(1.0085557d, new GammaParticle(1509600.0, 0.00082)), new(0.00199714d, new GammaParticle(1567900.0, 0.00079)), new(0.002396568d, new GammaParticle(1590900.0, 0.00078)), new(0.0018972829999999998d, new GammaParticle(1702200.0, 0.00073)), new(0.01198284d, new GammaParticle(2157000.0, 0.00057)), new(0.009186844d, new GammaParticle(2305800.0, 0.00054)), new(0.00099857d, new GammaParticle(2516800.0, 0.00049)), new(0.00299571d, new GammaParticle(2645200.0, 0.00047)), new(0.004393708d, new GammaParticle(2702400.0, 0.00046)), new(0.00399428d, new GammaParticle(2850300.0, 0.00043)), new(0.0006989990000000001d, new GammaParticle(2881000.0, 0.00043)), new(0.001597712d, new GammaParticle(2899500.0, 0.00043)), new(0.005392278d, new GammaParticle(3023400.0, 0.00041)), new(0.004793136d, new GammaParticle(3128500.0, 0.0004)), new(0.001198284d, new GammaParticle(3218000.0, 0.00039)), new(0.001697569d, new GammaParticle(4028000.0, 0.00031)), new(0.0006989990000000001d, new GammaParticle(4370100.0, 0.00028)), new(1.7786000000000002d, new GammaParticle(511000.0, 0.00243)), new(0.011145175785682377d, new GammaParticle(2440.0, 0.50813)), new(0.05480975496145672d, new GammaParticle(17374.0, 0.07136)), new(0.10445922424520054d, new GammaParticle(17479.0, 0.07093)), new(0.027409722071440323d, new GammaParticle(19681.0, 0.063)), new(0.03163081927044213d, new GammaParticle(19794.0, 0.06264)), new(0.00422109719900181d, new GammaParticle(19963.0, 0.06211)) } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {
            { 0.0d, 0d },
            { 4000.0d, 0.00000000226717d },
            { 8000.0d, 0.0000000951321d },
            { 12000.0d, 0.000000305567d },
            { 16000.0d, 0.000000629215d },
            { 20000.0d, 0.00000106513d },
            { 24000.0d, 0.00000161256d },
            { 28000.0d, 0.00000225764d },
            { 32000.0d, 0.00000299002d },
            { 36000.0d, 0.00000381639d },
            { 40000.0d, 0.00000472329d },
            { 44000.0d, 0.00000567059d },
            { 48000.0d, 0.00000668153d },
            { 52000.0d, 0.00000775477d },
            { 56000.0d, 0.00000884953d },
            { 60000.0d, 0.00000998624d },
            { 64000.0d, 0.000011164d },
            { 68000.0d, 0.0000123641d },
            { 72000.0d, 0.0000135874d },
            { 76000.0d, 0.0000148381d },
            { 80000.0d, 0.0000161084d },
            { 84000.0d, 0.0000173921d },
            { 88000.0d, 0.0000186942d },
            { 92000.0d, 0.0000200122d },
            { 96000.0d, 0.0000213383d },
            { 100000.0d, 0.0000226769d },
            { 110000.0d, 0.0000260653d },
            { 120000.0d, 0.0000295d },
            { 130000.0d, 0.0000329689d },
            { 140000.0d, 0.0000364621d },
            { 150000.0d, 0.0000399747d },
            { 160000.0d, 0.0000435009d },
            { 170000.0d, 0.0000470363d },
            { 180000.0d, 0.0000505771d },
            { 190000.0d, 0.0000541211d },
            { 200000.0d, 0.0000576661d },
            { 210000.0d, 0.0000612102d },
            { 220000.0d, 0.0000647516d },
            { 230000.0d, 0.0000682892d },
            { 240000.0d, 0.0000718219d },
            { 250000.0d, 0.0000753488d },
            { 260000.0d, 0.000078869d },
            { 270000.0d, 0.0000823816d },
            { 280000.0d, 0.000085886d },
            { 290000.0d, 0.0000893817d },
            { 300000.0d, 0.000092868d },
            { 310000.0d, 0.0000963444d },
            { 320000.0d, 0.0000998105d },
            { 330000.0d, 0.000103266d },
            { 340000.0d, 0.000106709d },
            { 350000.0d, 0.000110141d },
            { 360000.0d, 0.000113561d },
            { 370000.0d, 0.000116968d },
            { 380000.0d, 0.000120363d },
            { 390000.0d, 0.000123743d },
            { 400000.0d, 0.000127111d },
            { 410000.0d, 0.000130464d },
            { 420000.0d, 0.000133802d },
            { 430000.0d, 0.000137126d },
            { 440000.0d, 0.000140434d },
            { 450000.0d, 0.000143727d },
            { 460000.0d, 0.000147005d },
            { 470000.0d, 0.000150265d },
            { 480000.0d, 0.00015351d },
            { 490000.0d, 0.000156737d },
            { 500000.0d, 0.000159947d },
            { 510000.0d, 0.00016314d },
            { 520000.0d, 0.000166316d },
            { 530000.0d, 0.000169472d },
            { 540000.0d, 0.00017261d },
            { 550000.0d, 0.00017573d },
            { 560000.0d, 0.00017883d },
            { 570000.0d, 0.000181911d },
            { 580000.0d, 0.000184973d },
            { 590000.0d, 0.000188015d },
            { 600000.0d, 0.000191036d },
            { 610000.0d, 0.000194037d },
            { 620000.0d, 0.000197017d },
            { 630000.0d, 0.000199976d },
            { 640000.0d, 0.000202914d },
            { 650000.0d, 0.00020583d },
            { 660000.0d, 0.000208725d },
            { 670000.0d, 0.000211598d },
            { 680000.0d, 0.000214448d },
            { 690000.0d, 0.000217276d },
            { 700000.0d, 0.000220081d },
            { 710000.0d, 0.000222864d },
            { 720000.0d, 0.000225624d },
            { 730000.0d, 0.00022836d },
            { 740000.0d, 0.000231072d },
            { 750000.0d, 0.00023376d },
            { 760000.0d, 0.000236425d },
            { 770000.0d, 0.000239065d },
            { 780000.0d, 0.000241681d },
            { 790000.0d, 0.000244273d },
            { 800000.0d, 0.00024684d },
            { 810000.0d, 0.000249382d },
            { 820000.0d, 0.000251899d },
            { 830000.0d, 0.000254391d },
            { 840000.0d, 0.000256859d },
            { 850000.0d, 0.0002593d },
            { 860000.0d, 0.000261716d },
            { 870000.0d, 0.000264106d },
            { 880000.0d, 0.000266471d },
            { 890000.0d, 0.000268809d },
            { 900000.0d, 0.000271121d },
            { 910000.0d, 0.000273407d },
            { 920000.0d, 0.000275667d },
            { 930000.0d, 0.0002779d },
            { 940000.0d, 0.000280107d },
            { 950000.0d, 0.000282288d },
            { 960000.0d, 0.000284442d },
            { 970000.0d, 0.00028657d },
            { 980000.0d, 0.000288671d },
            { 990000.0d, 0.000290745d },
            { 1000000.0d, 0.000292791d },
            { 1013000.0d, 0.000295412d },
            { 1026000.0d, 0.000297988d },
            { 1039000.0d, 0.000300518d },
            { 1052000.0d, 0.000303002d },
            { 1065000.0d, 0.00030544d },
            { 1078000.0d, 0.000307833d },
            { 1091000.0d, 0.000310181d },
            { 1104000.0d, 0.000312482d },
            { 1117000.0d, 0.000314738d },
            { 1130000.0d, 0.000316948d },
            { 1143000.0d, 0.000319114d },
            { 1156000.0d, 0.000321233d },
            { 1169000.0d, 0.000323307d },
            { 1182000.0d, 0.000325337d },
            { 1195000.0d, 0.00032732d },
            { 1208000.0d, 0.000329259d },
            { 1221000.0d, 0.000331154d },
            { 1234000.0d, 0.000333004d },
            { 1247000.0d, 0.000334809d },
            { 1260000.0d, 0.000336571d },
            { 1273000.0d, 0.000338289d },
            { 1286000.0d, 0.000339963d },
            { 1299000.0d, 0.000341594d },
            { 1312000.0d, 0.000343182d },
            { 1325000.0d, 0.000344728d },
            { 1338000.0d, 0.000346231d },
            { 1351000.0d, 0.000347692d },
            { 1364000.0d, 0.000349111d },
            { 1377000.0d, 0.000350489d },
            { 1390000.0d, 0.000351827d },
            { 1403000.0d, 0.000353123d },
            { 1416000.0d, 0.000354374d },
            { 1429000.0d, 0.000355576d },
            { 1442000.0d, 0.000356729d },
            { 1455000.0d, 0.000357833d },
            { 1468000.0d, 0.000358889d },
            { 1481000.0d, 0.000359896d },
            { 1494000.0d, 0.000360855d },
            { 1507000.0d, 0.000361766d },
            { 1520000.0d, 0.000362629d },
            { 1533000.0d, 0.000363443d },
            { 1546000.0d, 0.000364211d },
            { 1559000.0d, 0.000364931d },
            { 1572000.0d, 0.000365604d },
            { 1585000.0d, 0.00036623d },
            { 1598000.0d, 0.000366809d },
            { 1611000.0d, 0.000367341d },
            { 1624000.0d, 0.000367827d },
            { 1637000.0d, 0.000368268d },
            { 1650000.0d, 0.000368663d },
            { 1663000.0d, 0.000369012d },
            { 1676000.0d, 0.000369317d },
            { 1689000.0d, 0.000369577d },
            { 1702000.0d, 0.000369792d },
            { 1715000.0d, 0.000369964d },
            { 1728000.0d, 0.000370091d },
            { 1741000.0d, 0.000370175d },
            { 1754000.0d, 0.000370218d },
            { 1767000.0d, 0.000370217d },
            { 1780000.0d, 0.000370174d },
            { 1793000.0d, 0.00037009d },
            { 1806000.0d, 0.000369964d },
            { 1819000.0d, 0.000369798d },
            { 1832000.0d, 0.000369591d },
            { 1845000.0d, 0.000369345d },
            { 1858000.0d, 0.00036906d },
            { 1871000.0d, 0.000368735d },
            { 1884000.0d, 0.000368372d },
            { 1897000.0d, 0.000367972d },
            { 1910000.0d, 0.000367534d },
            { 1923000.0d, 0.000367059d },
            { 1936000.0d, 0.000366549d },
            { 1949000.0d, 0.000366002d },
            { 1962000.0d, 0.000365411d },
            { 1975000.0d, 0.000364771d },
            { 1988000.0d, 0.000364084d },
            { 2001000.0d, 0.000363349d },
            { 2014000.0d, 0.000362566d },
            { 2027000.0d, 0.000361737d },
            { 2040000.0d, 0.000360859d },
            { 2053000.0d, 0.000359935d },
            { 2066000.0d, 0.000358965d },
            { 2079000.0d, 0.000357947d },
            { 2092000.0d, 0.000356884d },
            { 2105000.0d, 0.000355775d },
            { 2118000.0d, 0.000354621d },
            { 2131000.0d, 0.00035342d },
            { 2144000.0d, 0.000352175d },
            { 2157000.0d, 0.000350885d },
            { 2170000.0d, 0.000349551d },
            { 2183000.0d, 0.000348173d },
            { 2196000.0d, 0.00034675d },
            { 2209000.0d, 0.000345285d },
            { 2222000.0d, 0.000343776d },
            { 2235000.0d, 0.000342224d },
            { 2248000.0d, 0.00034063d },
            { 2261000.0d, 0.000338995d },
            { 2274000.0d, 0.000337317d },
            { 2287000.0d, 0.000335598d },
            { 2300000.0d, 0.000333837d },
            { 2313000.0d, 0.000332037d },
            { 2326000.0d, 0.000330196d },
            { 2339000.0d, 0.000328316d },
            { 2352000.0d, 0.000326397d },
            { 2365000.0d, 0.000324438d },
            { 2378000.0d, 0.000322442d },
            { 2391000.0d, 0.000320407d },
            { 2404000.0d, 0.000318335d },
            { 2417000.0d, 0.000316226d },
            { 2430000.0d, 0.000314081d },
            { 2443000.0d, 0.000311898d },
            { 2456000.0d, 0.000309681d },
            { 2469000.0d, 0.000307429d },
            { 2482000.0d, 0.000305141d },
            { 2495000.0d, 0.00030282d },
            { 2508000.0d, 0.000300465d },
            { 2521000.0d, 0.000298078d },
            { 2534000.0d, 0.000295658d },
            { 2547000.0d, 0.000293205d },
            { 2560000.0d, 0.000290722d },
            { 2573000.0d, 0.000288208d },
            { 2586000.0d, 0.000285663d },
            { 2599000.0d, 0.000283088d },
            { 2612000.0d, 0.000280485d },
            { 2625000.0d, 0.000277854d },
            { 2638000.0d, 0.000275194d },
            { 2651000.0d, 0.000272507d },
            { 2664000.0d, 0.000269793d },
            { 2677000.0d, 0.000267053d },
            { 2690000.0d, 0.000264288d },
            { 2703000.0d, 0.000261498d },
            { 2716000.0d, 0.000258683d },
            { 2729000.0d, 0.000255846d },
            { 2742000.0d, 0.000252986d },
            { 2755000.0d, 0.000250104d },
            { 2768000.0d, 0.0002472d },
            { 2781000.0d, 0.000244275d },
            { 2794000.0d, 0.00024133d },
            { 2807000.0d, 0.000238367d },
            { 2820000.0d, 0.000235384d },
            { 2833000.0d, 0.000232384d },
            { 2846000.0d, 0.000229366d },
            { 2859000.0d, 0.000226332d },
            { 2872000.0d, 0.000223282d },
            { 2885000.0d, 0.000220217d },
            { 2898000.0d, 0.000217138d },
            { 2911000.0d, 0.000214046d },
            { 2924000.0d, 0.000210941d },
            { 2937000.0d, 0.000207825d },
            { 2950000.0d, 0.000204697d },
            { 2963000.0d, 0.00020156d },
            { 2976000.0d, 0.000198413d },
            { 2989000.0d, 0.000195256d },
            { 3002000.0d, 0.000192093d },
            { 3015000.0d, 0.000188922d },
            { 3028000.0d, 0.000185745d },
            { 3041000.0d, 0.000182563d },
            { 3054000.0d, 0.000179376d },
            { 3067000.0d, 0.000176186d },
            { 3080000.0d, 0.000172994d },
            { 3093000.0d, 0.0001698d },
            { 3106000.0d, 0.000166604d },
            { 3119000.0d, 0.000163409d },
            { 3132000.0d, 0.000160215d },
            { 3145000.0d, 0.000157022d },
            { 3158000.0d, 0.000153832d },
            { 3171000.0d, 0.000150646d },
            { 3184000.0d, 0.000147465d },
            { 3197000.0d, 0.000144288d },
            { 3210000.0d, 0.000141119d },
            { 3223000.0d, 0.000137957d },
            { 3236000.0d, 0.000134803d },
            { 3249000.0d, 0.000131659d },
            { 3262000.0d, 0.000128525d },
            { 3275000.0d, 0.000125402d },
            { 3288000.0d, 0.000122292d },
            { 3301000.0d, 0.000119195d },
            { 3314000.0d, 0.000116112d },
            { 3327000.0d, 0.000113045d },
            { 3340000.0d, 0.000109995d },
            { 3353000.0d, 0.000106962d },
            { 3366000.0d, 0.000103947d },
            { 3379000.0d, 0.000100952d },
            { 3392000.0d, 0.0000979769d },
            { 3405000.0d, 0.0000950238d },
            { 3418000.0d, 0.0000920936d },
            { 3431000.0d, 0.0000891872d },
            { 3444000.0d, 0.0000863057d },
            { 3457000.0d, 0.0000834502d },
            { 3470000.0d, 0.0000806217d },
            { 3483000.0d, 0.0000778214d },
            { 3496000.0d, 0.0000750505d },
            { 3509000.0d, 0.00007231d },
            { 3522000.0d, 0.0000696011d },
            { 3535000.0d, 0.0000669248d },
            { 3548000.0d, 0.0000642824d },
            { 3561000.0d, 0.0000616751d },
            { 3574000.0d, 0.0000591039d },
            { 3587000.0d, 0.00005657d },
            { 3600000.0d, 0.0000540746d },
            { 3613000.0d, 0.000051619d },
            { 3626000.0d, 0.0000492041d },
            { 3639000.0d, 0.0000468314d },
            { 3652000.0d, 0.0000445019d },
            { 3665000.0d, 0.0000422168d },
            { 3678000.0d, 0.0000399775d },
            { 3691000.0d, 0.0000377851d },
            { 3704000.0d, 0.0000356408d },
            { 3717000.0d, 0.0000335459d },
            { 3730000.0d, 0.0000315016d },
            { 3743000.0d, 0.0000295092d },
            { 3756000.0d, 0.0000275699d },
            { 3769000.0d, 0.0000256849d },
            { 3782000.0d, 0.0000238556d },
            { 3795000.0d, 0.0000220833d },
            { 3808000.0d, 0.000020369d },
            { 3821000.0d, 0.0000187143d },
            { 3834000.0d, 0.0000171204d },
            { 3847000.0d, 0.0000155886d },
            { 3860000.0d, 0.00001412d },
            { 3873000.0d, 0.0000127162d },
            { 3886000.0d, 0.0000113783d },
            { 3899000.0d, 0.0000101077d },
            { 3912000.0d, 0.00000890574d },
            { 3925000.0d, 0.00000777368d },
            { 3938000.0d, 0.00000671289d },
            { 3951000.0d, 0.00000572466d },
            { 3964000.0d, 0.00000481035d },
            { 3977000.0d, 0.00000397127d },
            { 3990000.0d, 0.00000320875d },
            { 4003000.0d, 0.0000025241d },
            { 4016000.0d, 0.00000191865d },
            { 4029000.0d, 0.00000139372d },
            { 4042000.0d, 0.000000950577d },
            { 4055000.0d, 0.000000590517d },
            { 4068000.0d, 0.000000314773d },
            { 4081000.0d, 0.000000124517d },
            { 4094000.0d, 0.0000000207898d },
            { 4103000.0d, 0d },

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    