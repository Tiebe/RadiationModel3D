using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Niobium98 : RadioactiveSubstance
    {
        public override string name { get; } = "Niobium98";
        public override double halfLife { get; } = 2.86d;
        public override double atomicWeight { get; } = 97.91033d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {
            { 1.0d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Molybdenum98()), new(1.0d, new BetaParticle(-1, betaMinusSpectrum)), new(0.00312d, new GammaParticle(326700.0, 0.0038)), new(0.0338d, new GammaParticle(645100.0, 0.00192)), new(0.00169d, new GammaParticle(697400.0, 0.00178)), new(0.13d, new GammaParticle(787400.0, 0.00157)), new(0.0325d, new GammaParticle(971700.0, 0.00128)), new(0.0611d, new GammaParticle(1024300.0, 0.00121)), new(0.00884d, new GammaParticle(1250200.0, 0.00099)), new(0.01664d, new GammaParticle(1419700.0, 0.00087)), new(0.0338d, new GammaParticle(1432400.0, 0.00087)), new(0.006500000000000001d, new GammaParticle(1758400.0, 0.00071)), new(0.0032500000000000003d, new GammaParticle(1821000.0, 0.00068)), new(0.008607812650482572d, new GammaParticle(2440.0, 0.50813)), new(0.04834203240801117d, new GammaParticle(17374.0, 0.07136)), new(0.09213270899182613d, new GammaParticle(17479.0, 0.07093)), new(0.024175289117857615d, new GammaParticle(19681.0, 0.063)), new(0.027898283642007686d, new GammaParticle(19794.0, 0.06264)), new(0.0037229945241500726d, new GammaParticle(19963.0, 0.06211)) } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {
            { 0.0d, 0.0000804388d },
            { 6000.0d, 0.0000818002d },
            { 12000.0d, 0.0000831872d },
            { 18000.0d, 0.0000845998d },
            { 24000.0d, 0.0000860395d },
            { 30000.0d, 0.0000875118d },
            { 36000.0d, 0.0000890237d },
            { 42000.0d, 0.0000905764d },
            { 48000.0d, 0.0000921665d },
            { 54000.0d, 0.0000937891d },
            { 60000.0d, 0.0000954436d },
            { 66000.0d, 0.0000971205d },
            { 72000.0d, 0.0000988221d },
            { 78000.0d, 0.000100543d },
            { 84000.0d, 0.000102281d },
            { 90000.0d, 0.000104035d },
            { 96000.0d, 0.000105803d },
            { 102000.0d, 0.000107583d },
            { 112000.0d, 0.000110575d },
            { 122000.0d, 0.000113594d },
            { 132000.0d, 0.000116636d },
            { 142000.0d, 0.000119697d },
            { 152000.0d, 0.000122776d },
            { 162000.0d, 0.00012587d },
            { 172000.0d, 0.000128977d },
            { 182000.0d, 0.000132095d },
            { 192000.0d, 0.000135223d },
            { 202000.0d, 0.000138359d },
            { 212000.0d, 0.000141503d },
            { 222000.0d, 0.000144652d },
            { 232000.0d, 0.000147807d },
            { 242000.0d, 0.000150965d },
            { 252000.0d, 0.000154126d },
            { 262000.0d, 0.000157289d },
            { 272000.0d, 0.000160454d },
            { 282000.0d, 0.000163618d },
            { 292000.0d, 0.000166782d },
            { 302000.0d, 0.000169945d },
            { 312000.0d, 0.000173105d },
            { 322000.0d, 0.000176263d },
            { 332000.0d, 0.000179417d },
            { 342000.0d, 0.000182567d },
            { 352000.0d, 0.000185712d },
            { 362000.0d, 0.000188852d },
            { 372000.0d, 0.000191985d },
            { 382000.0d, 0.000195111d },
            { 392000.0d, 0.000198229d },
            { 402000.0d, 0.000201339d },
            { 412000.0d, 0.000204441d },
            { 422000.0d, 0.000207533d },
            { 432000.0d, 0.000210615d },
            { 442000.0d, 0.000213686d },
            { 452000.0d, 0.000216746d },
            { 462000.0d, 0.000219795d },
            { 472000.0d, 0.000222831d },
            { 482000.0d, 0.000225854d },
            { 492000.0d, 0.000228864d },
            { 502000.0d, 0.00023186d },
            { 512000.0d, 0.000234841d },
            { 522000.0d, 0.000237808d },
            { 532000.0d, 0.000240759d },
            { 542000.0d, 0.000243694d },
            { 552000.0d, 0.000246612d },
            { 562000.0d, 0.000249514d },
            { 572000.0d, 0.000252398d },
            { 582000.0d, 0.000255264d },
            { 592000.0d, 0.000258112d },
            { 602000.0d, 0.000260941d },
            { 612000.0d, 0.00026375d },
            { 622000.0d, 0.00026654d },
            { 632000.0d, 0.00026931d },
            { 642000.0d, 0.000272059d },
            { 652000.0d, 0.000274788d },
            { 662000.0d, 0.000277494d },
            { 672000.0d, 0.00028018d },
            { 682000.0d, 0.000282843d },
            { 692000.0d, 0.000285483d },
            { 702000.0d, 0.0002881d },
            { 712000.0d, 0.000290694d },
            { 722000.0d, 0.000293264d },
            { 732000.0d, 0.00029581d },
            { 742000.0d, 0.000298332d },
            { 752000.0d, 0.000300829d },
            { 762000.0d, 0.000303301d },
            { 772000.0d, 0.000305747d },
            { 782000.0d, 0.000308168d },
            { 792000.0d, 0.000310562d },
            { 802000.0d, 0.000312929d },
            { 812000.0d, 0.00031527d },
            { 822000.0d, 0.000317585d },
            { 832000.0d, 0.000319872d },
            { 842000.0d, 0.000322131d },
            { 852000.0d, 0.000324362d },
            { 862000.0d, 0.000326565d },
            { 872000.0d, 0.000328739d },
            { 882000.0d, 0.000330885d },
            { 892000.0d, 0.000333002d },
            { 902000.0d, 0.00033509d },
            { 912000.0d, 0.000337148d },
            { 922000.0d, 0.000339177d },
            { 932000.0d, 0.000341175d },
            { 942000.0d, 0.000343143d },
            { 952000.0d, 0.000345081d },
            { 962000.0d, 0.000346989d },
            { 972000.0d, 0.000348865d },
            { 982000.0d, 0.00035071d },
            { 992000.0d, 0.000352524d },
            { 1002000.0d, 0.000354307d },
            { 1017000.0d, 0.000356923d },
            { 1032000.0d, 0.000359466d },
            { 1047000.0d, 0.000361937d },
            { 1062000.0d, 0.000364336d },
            { 1077000.0d, 0.000366661d },
            { 1092000.0d, 0.000368912d },
            { 1107000.0d, 0.00037109d },
            { 1122000.0d, 0.000373193d },
            { 1137000.0d, 0.000375221d },
            { 1152000.0d, 0.000377174d },
            { 1167000.0d, 0.000379052d },
            { 1182000.0d, 0.000380853d },
            { 1197000.0d, 0.000382579d },
            { 1212000.0d, 0.000384229d },
            { 1227000.0d, 0.000385802d },
            { 1242000.0d, 0.000387298d },
            { 1257000.0d, 0.000388718d },
            { 1272000.0d, 0.00039006d },
            { 1287000.0d, 0.000391326d },
            { 1302000.0d, 0.000392516d },
            { 1317000.0d, 0.000393628d },
            { 1332000.0d, 0.000394663d },
            { 1347000.0d, 0.000395621d },
            { 1362000.0d, 0.000396502d },
            { 1377000.0d, 0.000397306d },
            { 1392000.0d, 0.000398034d },
            { 1407000.0d, 0.000398686d },
            { 1422000.0d, 0.000399262d },
            { 1437000.0d, 0.000399761d },
            { 1452000.0d, 0.000400185d },
            { 1467000.0d, 0.000400532d },
            { 1482000.0d, 0.000400805d },
            { 1497000.0d, 0.000401003d },
            { 1512000.0d, 0.000401127d },
            { 1527000.0d, 0.000401176d },
            { 1542000.0d, 0.000401152d },
            { 1557000.0d, 0.000401054d },
            { 1572000.0d, 0.000400884d },
            { 1587000.0d, 0.000400641d },
            { 1602000.0d, 0.000400326d },
            { 1617000.0d, 0.00039994d },
            { 1632000.0d, 0.000399484d },
            { 1647000.0d, 0.000398958d },
            { 1662000.0d, 0.000398362d },
            { 1677000.0d, 0.000397697d },
            { 1692000.0d, 0.000396965d },
            { 1707000.0d, 0.000396164d },
            { 1722000.0d, 0.000395297d },
            { 1737000.0d, 0.000394365d },
            { 1752000.0d, 0.000393368d },
            { 1767000.0d, 0.000392306d },
            { 1782000.0d, 0.000391181d },
            { 1797000.0d, 0.000389993d },
            { 1812000.0d, 0.000388744d },
            { 1827000.0d, 0.000387434d },
            { 1842000.0d, 0.000386064d },
            { 1857000.0d, 0.000384635d },
            { 1872000.0d, 0.000383149d },
            { 1887000.0d, 0.000381606d },
            { 1902000.0d, 0.000380007d },
            { 1917000.0d, 0.000378354d },
            { 1932000.0d, 0.000376647d },
            { 1947000.0d, 0.000374887d },
            { 1962000.0d, 0.000373077d },
            { 1977000.0d, 0.000371216d },
            { 1992000.0d, 0.000369307d },
            { 2007000.0d, 0.000367346d },
            { 2022000.0d, 0.000365337d },
            { 2037000.0d, 0.000363279d },
            { 2052000.0d, 0.000361174d },
            { 2067000.0d, 0.000359024d },
            { 2082000.0d, 0.000356828d },
            { 2097000.0d, 0.00035459d },
            { 2112000.0d, 0.00035231d },
            { 2127000.0d, 0.000349989d },
            { 2142000.0d, 0.000347629d },
            { 2157000.0d, 0.000345231d },
            { 2172000.0d, 0.000342797d },
            { 2187000.0d, 0.000340327d },
            { 2202000.0d, 0.000337825d },
            { 2217000.0d, 0.000335289d },
            { 2232000.0d, 0.000332724d },
            { 2247000.0d, 0.000330129d },
            { 2262000.0d, 0.000327507d },
            { 2277000.0d, 0.000324858d },
            { 2292000.0d, 0.000322185d },
            { 2307000.0d, 0.000319489d },
            { 2322000.0d, 0.000316772d },
            { 2337000.0d, 0.000314035d },
            { 2352000.0d, 0.00031128d },
            { 2367000.0d, 0.000308509d },
            { 2382000.0d, 0.000305724d },
            { 2397000.0d, 0.000302922d },
            { 2412000.0d, 0.0003001d },
            { 2427000.0d, 0.000297259d },
            { 2442000.0d, 0.0002944d },
            { 2457000.0d, 0.000291526d },
            { 2472000.0d, 0.000288637d },
            { 2487000.0d, 0.000285736d },
            { 2502000.0d, 0.000282824d },
            { 2517000.0d, 0.000279902d },
            { 2532000.0d, 0.000276973d },
            { 2547000.0d, 0.000274038d },
            { 2562000.0d, 0.000271098d },
            { 2577000.0d, 0.000268151d },
            { 2592000.0d, 0.000265199d },
            { 2607000.0d, 0.000262244d },
            { 2622000.0d, 0.000259288d },
            { 2637000.0d, 0.000256331d },
            { 2652000.0d, 0.000253376d },
            { 2667000.0d, 0.000250424d },
            { 2682000.0d, 0.000247477d },
            { 2697000.0d, 0.000244537d },
            { 2712000.0d, 0.000241606d },
            { 2727000.0d, 0.000238685d },
            { 2742000.0d, 0.000235776d },
            { 2757000.0d, 0.000232881d },
            { 2772000.0d, 0.000230002d },
            { 2787000.0d, 0.00022714d },
            { 2802000.0d, 0.000224298d },
            { 2817000.0d, 0.000221477d },
            { 2832000.0d, 0.000218678d },
            { 2847000.0d, 0.000215887d },
            { 2862000.0d, 0.000213086d },
            { 2877000.0d, 0.000210279d },
            { 2892000.0d, 0.000207464d },
            { 2907000.0d, 0.000204644d },
            { 2922000.0d, 0.000201819d },
            { 2937000.0d, 0.000198992d },
            { 2952000.0d, 0.000196162d },
            { 2967000.0d, 0.000193331d },
            { 2982000.0d, 0.0001905d },
            { 2997000.0d, 0.000187671d },
            { 3012000.0d, 0.000184845d },
            { 3027000.0d, 0.000182022d },
            { 3042000.0d, 0.000179204d },
            { 3057000.0d, 0.000176392d },
            { 3072000.0d, 0.000173588d },
            { 3087000.0d, 0.000170792d },
            { 3102000.0d, 0.000168006d },
            { 3117000.0d, 0.000165231d },
            { 3132000.0d, 0.000162469d },
            { 3147000.0d, 0.000159719d },
            { 3162000.0d, 0.000156984d },
            { 3177000.0d, 0.000154255d },
            { 3192000.0d, 0.000151526d },
            { 3207000.0d, 0.000148798d },
            { 3222000.0d, 0.000146072d },
            { 3237000.0d, 0.000143349d },
            { 3252000.0d, 0.000140631d },
            { 3267000.0d, 0.000137919d },
            { 3282000.0d, 0.000135212d },
            { 3297000.0d, 0.000132513d },
            { 3312000.0d, 0.000129821d },
            { 3327000.0d, 0.000127139d },
            { 3342000.0d, 0.000124469d },
            { 3357000.0d, 0.000121808d },
            { 3372000.0d, 0.000119161d },
            { 3387000.0d, 0.000116527d },
            { 3402000.0d, 0.000113907d },
            { 3417000.0d, 0.000111303d },
            { 3432000.0d, 0.000108716d },
            { 3447000.0d, 0.000106146d },
            { 3462000.0d, 0.000103596d },
            { 3477000.0d, 0.000101065d },
            { 3492000.0d, 0.0000985555d },
            { 3507000.0d, 0.000096068d },
            { 3522000.0d, 0.0000936038d },
            { 3537000.0d, 0.0000911641d },
            { 3552000.0d, 0.00008875d },
            { 3567000.0d, 0.0000863625d },
            { 3582000.0d, 0.0000840029d },
            { 3597000.0d, 0.0000816723d },
            { 3612000.0d, 0.000079372d },
            { 3627000.0d, 0.000077103d },
            { 3642000.0d, 0.0000748665d },
            { 3657000.0d, 0.0000726638d },
            { 3672000.0d, 0.0000704959d },
            { 3687000.0d, 0.0000683642d },
            { 3702000.0d, 0.0000662698d },
            { 3717000.0d, 0.0000642139d },
            { 3732000.0d, 0.0000621977d },
            { 3747000.0d, 0.0000602224d },
            { 3762000.0d, 0.0000582894d },
            { 3777000.0d, 0.0000563996d },
            { 3792000.0d, 0.0000545545d },
            { 3807000.0d, 0.000052755d },
            { 3822000.0d, 0.0000509987d },
            { 3837000.0d, 0.0000492852d },
            { 3852000.0d, 0.0000476155d },
            { 3867000.0d, 0.0000459827d },
            { 3882000.0d, 0.0000443675d },
            { 3897000.0d, 0.0000427695d },
            { 3912000.0d, 0.0000411895d },
            { 3927000.0d, 0.0000396281d },
            { 3942000.0d, 0.0000380859d },
            { 3957000.0d, 0.0000365636d },
            { 3972000.0d, 0.0000350619d },
            { 3987000.0d, 0.0000335816d },
            { 4002000.0d, 0.0000321231d },
            { 4017000.0d, 0.0000306874d },
            { 4032000.0d, 0.000029275d },
            { 4047000.0d, 0.0000278865d },
            { 4062000.0d, 0.0000265227d },
            { 4077000.0d, 0.0000251845d },
            { 4092000.0d, 0.0000238723d },
            { 4107000.0d, 0.0000225869d },
            { 4122000.0d, 0.0000213291d },
            { 4137000.0d, 0.0000200996d },
            { 4152000.0d, 0.0000188989d },
            { 4167000.0d, 0.0000177281d },
            { 4182000.0d, 0.0000165875d },
            { 4197000.0d, 0.0000154782d },
            { 4212000.0d, 0.0000144007d },
            { 4227000.0d, 0.0000133557d },
            { 4242000.0d, 0.0000123442d },
            { 4257000.0d, 0.0000113667d },
            { 4272000.0d, 0.000010424d },
            { 4287000.0d, 0.00000951692d },
            { 4302000.0d, 0.00000864612d },
            { 4317000.0d, 0.00000781237d },
            { 4332000.0d, 0.00000701643d },
            { 4347000.0d, 0.00000625906d },
            { 4362000.0d, 0.00000554101d },
            { 4377000.0d, 0.00000486304d },
            { 4392000.0d, 0.0000042259d },
            { 4407000.0d, 0.00000363035d },
            { 4422000.0d, 0.00000307716d },
            { 4437000.0d, 0.00000256708d },
            { 4452000.0d, 0.00000210088d },
            { 4467000.0d, 0.00000167931d },
            { 4482000.0d, 0.00000130312d },
            { 4497000.0d, 0.000000973068d },
            { 4512000.0d, 0.00000068989d },
            { 4527000.0d, 0.00000045432d },
            { 4542000.0d, 0.000000267072d },
            { 4557000.0d, 0.000000128831d },
            { 4572000.0d, 0.0000000402322d },
            { 4587000.0d, 0.00000000176875d },
            { 4591000.0d, 0d },

        }; 
    }
}
    