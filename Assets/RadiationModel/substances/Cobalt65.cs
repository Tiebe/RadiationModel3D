using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Cobalt65 : RadioactiveSubstance
    {
        public override string name { get; } = "Cobalt65";
        public override double halfLife { get; } = 1.16d;
        public override double atomicWeight { get; } = 64.93646d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {
            { 1.0d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Nickel65()), new(1.0d, new BetaParticle(-1, betaMinusSpectrum)), new(0.00435d, new GammaParticle(63400.0, 0.01956)), new(0.023780000000000003d, new GammaParticle(310400.0, 0.00399)), new(0.02291d, new GammaParticle(963400.0, 0.00129)), new(0.028999999999999998d, new GammaParticle(1141100.0, 0.00109)), new(0.01131d, new GammaParticle(1210600.0, 0.00102)), new(0.01218d, new GammaParticle(1273200.0, 0.00097)), new(0.0001563605064d, new GammaParticle(874.0, 1.41858)), new(0.0015377898287265769d, new GammaParticle(7461.0, 0.16618)), new(0.003001151109926965d, new GammaParticle(7478.0, 0.1658)), new(0.0006254660613464582d, new GammaParticle(8296.0, 0.14945)), new(0.0006254660613464582d, new GammaParticle(8296.0, 0.14945)) } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {
            { 0.0d, 0.0000223947d },
            { 15000.0d, 0.0000237122d },
            { 30000.0d, 0.0000251731d },
            { 45000.0d, 0.0000267776d },
            { 60000.0d, 0.0000285035d },
            { 75000.0d, 0.0000302753d },
            { 90000.0d, 0.0000320815d },
            { 105000.0d, 0.0000339156d },
            { 120000.0d, 0.0000357728d },
            { 135000.0d, 0.000037651d },
            { 150000.0d, 0.0000395488d },
            { 165000.0d, 0.0000414655d },
            { 180000.0d, 0.0000434005d },
            { 195000.0d, 0.0000453531d },
            { 210000.0d, 0.0000473232d },
            { 225000.0d, 0.0000493099d },
            { 240000.0d, 0.000051313d },
            { 255000.0d, 0.000053332d },
            { 270000.0d, 0.0000553666d },
            { 285000.0d, 0.0000574162d },
            { 300000.0d, 0.0000594803d },
            { 315000.0d, 0.0000615585d },
            { 330000.0d, 0.0000636503d },
            { 345000.0d, 0.0000657553d },
            { 360000.0d, 0.0000678728d },
            { 375000.0d, 0.0000700024d },
            { 390000.0d, 0.0000721436d },
            { 405000.0d, 0.000074296d },
            { 420000.0d, 0.0000764589d },
            { 435000.0d, 0.0000786319d },
            { 450000.0d, 0.0000808144d },
            { 465000.0d, 0.0000830059d },
            { 480000.0d, 0.0000852061d },
            { 495000.0d, 0.0000874142d },
            { 510000.0d, 0.0000896298d },
            { 525000.0d, 0.0000918524d },
            { 540000.0d, 0.0000940816d },
            { 555000.0d, 0.0000963167d },
            { 570000.0d, 0.0000985573d },
            { 585000.0d, 0.000100803d },
            { 600000.0d, 0.000103053d },
            { 615000.0d, 0.000105307d },
            { 630000.0d, 0.000107564d },
            { 645000.0d, 0.000109825d },
            { 660000.0d, 0.000112088d },
            { 675000.0d, 0.000114353d },
            { 690000.0d, 0.00011662d },
            { 705000.0d, 0.000118888d },
            { 720000.0d, 0.000121156d },
            { 735000.0d, 0.000123425d },
            { 750000.0d, 0.000125693d },
            { 765000.0d, 0.00012796d },
            { 780000.0d, 0.000130227d },
            { 795000.0d, 0.000132491d },
            { 810000.0d, 0.000134753d },
            { 825000.0d, 0.000137013d },
            { 840000.0d, 0.000139271d },
            { 855000.0d, 0.000141524d },
            { 870000.0d, 0.000143774d },
            { 885000.0d, 0.000146019d },
            { 900000.0d, 0.00014826d },
            { 915000.0d, 0.000150496d },
            { 930000.0d, 0.000152725d },
            { 945000.0d, 0.000154949d },
            { 960000.0d, 0.000157167d },
            { 975000.0d, 0.000159378d },
            { 990000.0d, 0.000161582d },
            { 1005000.0d, 0.000163778d },
            { 1024000.0d, 0.000166548d },
            { 1043000.0d, 0.000169306d },
            { 1062000.0d, 0.000172048d },
            { 1081000.0d, 0.000174776d },
            { 1100000.0d, 0.000177488d },
            { 1119000.0d, 0.000180183d },
            { 1138000.0d, 0.000182862d },
            { 1157000.0d, 0.000185522d },
            { 1176000.0d, 0.000188164d },
            { 1195000.0d, 0.000190787d },
            { 1214000.0d, 0.000193389d },
            { 1233000.0d, 0.00019597d },
            { 1252000.0d, 0.000198531d },
            { 1271000.0d, 0.000201069d },
            { 1290000.0d, 0.000203585d },
            { 1309000.0d, 0.000206077d },
            { 1328000.0d, 0.000208547d },
            { 1347000.0d, 0.00021099d },
            { 1366000.0d, 0.000213409d },
            { 1385000.0d, 0.000215803d },
            { 1404000.0d, 0.00021817d },
            { 1423000.0d, 0.000220511d },
            { 1442000.0d, 0.000222824d },
            { 1461000.0d, 0.000225109d },
            { 1480000.0d, 0.000227366d },
            { 1499000.0d, 0.000229593d },
            { 1518000.0d, 0.000231791d },
            { 1537000.0d, 0.00023396d },
            { 1556000.0d, 0.000236098d },
            { 1575000.0d, 0.000238205d },
            { 1594000.0d, 0.00024028d },
            { 1613000.0d, 0.000242325d },
            { 1632000.0d, 0.000244335d },
            { 1651000.0d, 0.000246314d },
            { 1670000.0d, 0.00024826d },
            { 1689000.0d, 0.000250171d },
            { 1708000.0d, 0.000252049d },
            { 1727000.0d, 0.000253892d },
            { 1746000.0d, 0.0002557d },
            { 1765000.0d, 0.000257473d },
            { 1784000.0d, 0.000259211d },
            { 1803000.0d, 0.000260913d },
            { 1822000.0d, 0.000262579d },
            { 1841000.0d, 0.000264207d },
            { 1860000.0d, 0.000265799d },
            { 1879000.0d, 0.000267353d },
            { 1898000.0d, 0.000268871d },
            { 1917000.0d, 0.00027035d },
            { 1936000.0d, 0.00027179d },
            { 1955000.0d, 0.000273193d },
            { 1974000.0d, 0.000274556d },
            { 1993000.0d, 0.000275881d },
            { 2012000.0d, 0.000277166d },
            { 2031000.0d, 0.000278412d },
            { 2050000.0d, 0.000279618d },
            { 2069000.0d, 0.000280784d },
            { 2088000.0d, 0.00028191d },
            { 2107000.0d, 0.000282995d },
            { 2126000.0d, 0.00028404d },
            { 2145000.0d, 0.000285044d },
            { 2164000.0d, 0.000286008d },
            { 2183000.0d, 0.00028693d },
            { 2202000.0d, 0.00028781d },
            { 2221000.0d, 0.00028865d },
            { 2240000.0d, 0.000289448d },
            { 2259000.0d, 0.000290204d },
            { 2278000.0d, 0.000290919d },
            { 2297000.0d, 0.000291591d },
            { 2316000.0d, 0.000292221d },
            { 2335000.0d, 0.00029281d },
            { 2354000.0d, 0.000293356d },
            { 2373000.0d, 0.00029386d },
            { 2392000.0d, 0.000294322d },
            { 2411000.0d, 0.00029474d },
            { 2430000.0d, 0.000295117d },
            { 2449000.0d, 0.000295452d },
            { 2468000.0d, 0.000295744d },
            { 2487000.0d, 0.000295993d },
            { 2506000.0d, 0.000296199d },
            { 2525000.0d, 0.000296364d },
            { 2544000.0d, 0.000296486d },
            { 2563000.0d, 0.000296565d },
            { 2582000.0d, 0.000296602d },
            { 2601000.0d, 0.000296597d },
            { 2620000.0d, 0.000296549d },
            { 2639000.0d, 0.000296459d },
            { 2658000.0d, 0.000296327d },
            { 2677000.0d, 0.000296152d },
            { 2696000.0d, 0.000295936d },
            { 2715000.0d, 0.000295678d },
            { 2734000.0d, 0.000295377d },
            { 2753000.0d, 0.000295035d },
            { 2772000.0d, 0.000294651d },
            { 2791000.0d, 0.000294226d },
            { 2810000.0d, 0.000293759d },
            { 2829000.0d, 0.000293252d },
            { 2848000.0d, 0.000292703d },
            { 2867000.0d, 0.000292113d },
            { 2886000.0d, 0.000291482d },
            { 2905000.0d, 0.000290812d },
            { 2924000.0d, 0.0002901d },
            { 2943000.0d, 0.000289349d },
            { 2962000.0d, 0.000288558d },
            { 2981000.0d, 0.000287726d },
            { 3000000.0d, 0.000286856d },
            { 3019000.0d, 0.000285946d },
            { 3038000.0d, 0.000284997d },
            { 3057000.0d, 0.00028401d },
            { 3076000.0d, 0.000282984d },
            { 3095000.0d, 0.00028192d },
            { 3114000.0d, 0.000280818d },
            { 3133000.0d, 0.000279678d },
            { 3152000.0d, 0.000278501d },
            { 3171000.0d, 0.000277287d },
            { 3190000.0d, 0.000276037d },
            { 3209000.0d, 0.00027475d },
            { 3228000.0d, 0.000273426d },
            { 3247000.0d, 0.000272067d },
            { 3266000.0d, 0.000270673d },
            { 3285000.0d, 0.000269245d },
            { 3304000.0d, 0.00026778d },
            { 3323000.0d, 0.000266283d },
            { 3342000.0d, 0.000264751d },
            { 3361000.0d, 0.000263186d },
            { 3380000.0d, 0.000261588d },
            { 3399000.0d, 0.000259957d },
            { 3418000.0d, 0.000258293d },
            { 3437000.0d, 0.000256598d },
            { 3456000.0d, 0.000254872d },
            { 3475000.0d, 0.000253115d },
            { 3494000.0d, 0.000251328d },
            { 3513000.0d, 0.00024951d },
            { 3532000.0d, 0.000247663d },
            { 3551000.0d, 0.000245787d },
            { 3570000.0d, 0.000243882d },
            { 3589000.0d, 0.00024195d },
            { 3608000.0d, 0.00023999d },
            { 3627000.0d, 0.000238003d },
            { 3646000.0d, 0.00023599d },
            { 3665000.0d, 0.00023395d },
            { 3684000.0d, 0.000231885d },
            { 3703000.0d, 0.000229795d },
            { 3722000.0d, 0.000227681d },
            { 3741000.0d, 0.000225543d },
            { 3760000.0d, 0.000223383d },
            { 3779000.0d, 0.000221199d },
            { 3798000.0d, 0.000218993d },
            { 3817000.0d, 0.000216767d },
            { 3836000.0d, 0.00021452d },
            { 3855000.0d, 0.000212251d },
            { 3874000.0d, 0.000209964d },
            { 3893000.0d, 0.000207657d },
            { 3912000.0d, 0.000205333d },
            { 3931000.0d, 0.000202991d },
            { 3950000.0d, 0.000200632d },
            { 3969000.0d, 0.000198257d },
            { 3988000.0d, 0.000195866d },
            { 4007000.0d, 0.00019346d },
            { 4026000.0d, 0.00019104d },
            { 4045000.0d, 0.000188606d },
            { 4064000.0d, 0.000186159d },
            { 4083000.0d, 0.000183701d },
            { 4102000.0d, 0.000181231d },
            { 4121000.0d, 0.00017875d },
            { 4140000.0d, 0.000176259d },
            { 4159000.0d, 0.00017376d },
            { 4178000.0d, 0.000171252d },
            { 4197000.0d, 0.000168737d },
            { 4216000.0d, 0.000166214d },
            { 4235000.0d, 0.000163685d },
            { 4254000.0d, 0.00016115d },
            { 4273000.0d, 0.000158612d },
            { 4292000.0d, 0.00015607d },
            { 4311000.0d, 0.000153525d },
            { 4330000.0d, 0.000150977d },
            { 4349000.0d, 0.000148429d },
            { 4368000.0d, 0.00014588d },
            { 4387000.0d, 0.000143331d },
            { 4406000.0d, 0.000140784d },
            { 4425000.0d, 0.000138239d },
            { 4444000.0d, 0.000135698d },
            { 4463000.0d, 0.000133159d },
            { 4482000.0d, 0.000130626d },
            { 4501000.0d, 0.000128099d },
            { 4520000.0d, 0.000125577d },
            { 4539000.0d, 0.000123064d },
            { 4558000.0d, 0.000120559d },
            { 4577000.0d, 0.000118062d },
            { 4596000.0d, 0.000115577d },
            { 4615000.0d, 0.000113102d },
            { 4634000.0d, 0.000110639d },
            { 4653000.0d, 0.000108191d },
            { 4672000.0d, 0.000105755d },
            { 4691000.0d, 0.000103334d },
            { 4710000.0d, 0.000100922d },
            { 4729000.0d, 0.0000985209d },
            { 4748000.0d, 0.0000961305d },
            { 4767000.0d, 0.0000937517d },
            { 4786000.0d, 0.0000913855d },
            { 4805000.0d, 0.0000890328d },
            { 4824000.0d, 0.0000866938d },
            { 4843000.0d, 0.0000843668d },
            { 4862000.0d, 0.0000820517d },
            { 4881000.0d, 0.0000797496d },
            { 4900000.0d, 0.0000774613d },
            { 4919000.0d, 0.0000751876d },
            { 4938000.0d, 0.0000729293d },
            { 4957000.0d, 0.0000706874d },
            { 4976000.0d, 0.0000684626d },
            { 4995000.0d, 0.0000662559d },
            { 5014000.0d, 0.0000640681d },
            { 5033000.0d, 0.0000619d },
            { 5052000.0d, 0.0000597528d },
            { 5071000.0d, 0.0000576271d },
            { 5090000.0d, 0.0000555239d },
            { 5109000.0d, 0.0000534441d },
            { 5128000.0d, 0.0000513886d },
            { 5147000.0d, 0.0000493585d },
            { 5166000.0d, 0.0000473545d },
            { 5185000.0d, 0.0000453777d },
            { 5204000.0d, 0.0000434289d },
            { 5223000.0d, 0.0000415093d },
            { 5242000.0d, 0.0000396195d },
            { 5261000.0d, 0.0000377608d },
            { 5280000.0d, 0.000035934d },
            { 5299000.0d, 0.0000341401d },
            { 5318000.0d, 0.0000323802d },
            { 5337000.0d, 0.0000306551d },
            { 5356000.0d, 0.000028966d },
            { 5375000.0d, 0.0000273138d },
            { 5394000.0d, 0.0000256994d },
            { 5413000.0d, 0.0000241241d },
            { 5432000.0d, 0.0000225888d },
            { 5451000.0d, 0.0000210945d },
            { 5470000.0d, 0.0000196423d },
            { 5489000.0d, 0.0000182332d },
            { 5508000.0d, 0.0000168682d },
            { 5527000.0d, 0.0000155485d },
            { 5546000.0d, 0.0000142752d },
            { 5565000.0d, 0.0000130492d },
            { 5584000.0d, 0.0000118717d },
            { 5603000.0d, 0.0000107436d },
            { 5622000.0d, 0.0000096663d },
            { 5641000.0d, 0.00000864069d },
            { 5660000.0d, 0.0000076676d },
            { 5679000.0d, 0.0000067474d },
            { 5698000.0d, 0.00000588113d },
            { 5717000.0d, 0.00000506987d },
            { 5736000.0d, 0.00000431469d },
            { 5755000.0d, 0.00000361667d },
            { 5774000.0d, 0.00000297691d },
            { 5793000.0d, 0.00000239648d },
            { 5812000.0d, 0.00000187647d },
            { 5831000.0d, 0.00000141795d },
            { 5850000.0d, 0.00000102199d },
            { 5869000.0d, 0.000000689642d },
            { 5888000.0d, 0.000000421945d },
            { 5907000.0d, 0.000000219513d },
            { 5926000.0d, 0.0000000823057d },
            { 5945000.0d, 0.0000000110133d },
            { 5956000.0d, 0d },

        }; 
    }
}
    