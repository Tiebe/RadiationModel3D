using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Indium127n : RadioactiveSubstance
    {
        public override string name { get; } = "Indium127n";
        public override double halfLife { get; } = 1.04d;
        public override double atomicWeight { get; } = 126.91937d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {
            { 1.0d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Tin127()), new(1.0d, new BetaParticle(-1, betaMinusSpectrum)), new(0.000221d, new GammaParticle(16520.0, 0.07505)), new(0.03485d, new GammaParticle(104300.0, 0.01189)), new(0.014025000000000001d, new GammaParticle(184810.0, 0.00671)), new(0.01955d, new GammaParticle(219200.0, 0.00566)), new(0.00935d, new GammaParticle(236000.0, 0.00525)), new(0.02635d, new GammaParticle(257300.0, 0.00482)), new(0.01955d, new GammaParticle(301140.0, 0.00412)), new(0.029750000000000002d, new GammaParticle(359580.0, 0.00345)), new(0.011049999999999999d, new GammaParticle(395600.0, 0.00313)), new(0.0255d, new GammaParticle(405400.0, 0.00306)), new(0.014450000000000001d, new GammaParticle(406900.0, 0.00305)), new(0.009435d, new GammaParticle(464600.0, 0.00267)), new(0.00425d, new GammaParticle(501900.0, 0.00247)), new(0.08839999999999999d, new GammaParticle(567260.0, 0.00219)), new(0.014450000000000001d, new GammaParticle(583200.0, 0.00213)), new(0.0255d, new GammaParticle(646340.0, 0.00192)), new(0.0076500000000000005d, new GammaParticle(650500.0, 0.00191)), new(0.014450000000000001d, new GammaParticle(688000.0, 0.0018)), new(0.391d, new GammaParticle(715520.0, 0.00173)), new(0.0799d, new GammaParticle(732040.0, 0.00169)), new(0.027200000000000002d, new GammaParticle(803200.0, 0.00154)), new(0.0408d, new GammaParticle(821890.0, 0.00151)), new(0.0527d, new GammaParticle(871400.0, 0.00142)), new(0.08839999999999999d, new GammaParticle(952800.0, 0.0013)), new(0.014450000000000001d, new GammaParticle(974700.0, 0.00127)), new(0.0255d, new GammaParticle(979100.0, 0.00127)), new(0.04845d, new GammaParticle(1071300.0, 0.00116)), new(0.85d, new GammaParticle(1094700.0, 0.00113)), new(0.00935d, new GammaParticle(1217400.0, 0.00102)), new(0.1258d, new GammaParticle(1242710.0, 0.001)), new(0.0204d, new GammaParticle(1293300.0, 0.00096)), new(0.0085d, new GammaParticle(1373100.0, 0.0009)), new(0.028900000000000002d, new GammaParticle(1439400.0, 0.00086)), new(0.0391d, new GammaParticle(1461020.0, 0.00085)), new(0.01955d, new GammaParticle(1521800.0, 0.00081)), new(0.034d, new GammaParticle(1558500.0, 0.0008)), new(0.013600000000000001d, new GammaParticle(1689000.0, 0.00073)), new(0.2278d, new GammaParticle(1778300.0, 0.0007)), new(0.029750000000000002d, new GammaParticle(1819700.0, 0.00068)), new(0.014450000000000001d, new GammaParticle(2103600.0, 0.00059)), new(0.09179999999999999d, new GammaParticle(2510300.0, 0.00049)), new(0.00425d, new GammaParticle(2766300.0, 0.00045)), new(0.0068000000000000005d, new GammaParticle(2804900.0, 0.00044)), new(0.034d, new GammaParticle(3753.0, 0.33036)), new(0.01d, new GammaParticle(25044.0, 0.04951)), new(0.0187d, new GammaParticle(25271.0, 0.04906)), new(0.0053d, new GammaParticle(28579.0, 0.04338)), new(0.0063d, new GammaParticle(28810.0, 0.04304)), new(0.00104d, new GammaParticle(29107.0, 0.0426)) } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {
            { 0.0d, 0.0000426019d },
            { 14000.0d, 0.0000443602d },
            { 28000.0d, 0.0000461633d },
            { 42000.0d, 0.0000480111d },
            { 56000.0d, 0.0000499174d },
            { 70000.0d, 0.0000518866d },
            { 84000.0d, 0.0000539113d },
            { 98000.0d, 0.000055983d },
            { 112000.0d, 0.0000580953d },
            { 126000.0d, 0.0000602427d },
            { 140000.0d, 0.0000624209d },
            { 154000.0d, 0.0000646269d },
            { 168000.0d, 0.0000668576d },
            { 182000.0d, 0.0000691106d },
            { 196000.0d, 0.0000713843d },
            { 210000.0d, 0.0000736765d },
            { 224000.0d, 0.0000759858d },
            { 238000.0d, 0.000078311d },
            { 252000.0d, 0.0000806506d },
            { 266000.0d, 0.0000830035d },
            { 280000.0d, 0.0000853686d },
            { 294000.0d, 0.0000877449d },
            { 308000.0d, 0.0000901315d },
            { 322000.0d, 0.0000925274d },
            { 336000.0d, 0.0000949317d },
            { 350000.0d, 0.0000973437d },
            { 364000.0d, 0.0000997623d },
            { 378000.0d, 0.000102187d },
            { 392000.0d, 0.000104617d },
            { 406000.0d, 0.000107051d },
            { 420000.0d, 0.000109489d },
            { 434000.0d, 0.000111931d },
            { 448000.0d, 0.000114374d },
            { 462000.0d, 0.000116819d },
            { 476000.0d, 0.000119266d },
            { 490000.0d, 0.000121712d },
            { 504000.0d, 0.000124159d },
            { 518000.0d, 0.000126604d },
            { 532000.0d, 0.000129048d },
            { 546000.0d, 0.00013149d },
            { 560000.0d, 0.000133929d },
            { 574000.0d, 0.000136365d },
            { 588000.0d, 0.000138797d },
            { 602000.0d, 0.000141225d },
            { 616000.0d, 0.000143648d },
            { 630000.0d, 0.000146065d },
            { 644000.0d, 0.000148477d },
            { 658000.0d, 0.000150882d },
            { 672000.0d, 0.000153279d },
            { 686000.0d, 0.000155669d },
            { 700000.0d, 0.000158051d },
            { 714000.0d, 0.000160425d },
            { 728000.0d, 0.000162789d },
            { 742000.0d, 0.000165144d },
            { 756000.0d, 0.000167489d },
            { 770000.0d, 0.000169823d },
            { 784000.0d, 0.000172147d },
            { 798000.0d, 0.000174459d },
            { 812000.0d, 0.000176759d },
            { 826000.0d, 0.000179047d },
            { 840000.0d, 0.000181323d },
            { 854000.0d, 0.000183585d },
            { 868000.0d, 0.000185834d },
            { 882000.0d, 0.000188069d },
            { 896000.0d, 0.000190289d },
            { 910000.0d, 0.000192495d },
            { 924000.0d, 0.000194686d },
            { 938000.0d, 0.000196861d },
            { 952000.0d, 0.00019902d },
            { 966000.0d, 0.000201163d },
            { 980000.0d, 0.00020329d },
            { 994000.0d, 0.0002054d },
            { 1008000.0d, 0.000207492d },
            { 1031000.0d, 0.000210891d },
            { 1054000.0d, 0.00021424d },
            { 1077000.0d, 0.000217539d },
            { 1100000.0d, 0.000220786d },
            { 1123000.0d, 0.00022398d },
            { 1146000.0d, 0.000227118d },
            { 1169000.0d, 0.000230201d },
            { 1192000.0d, 0.000233227d },
            { 1215000.0d, 0.000236195d },
            { 1238000.0d, 0.000239101d },
            { 1261000.0d, 0.000241949d },
            { 1284000.0d, 0.000244734d },
            { 1307000.0d, 0.000247455d },
            { 1330000.0d, 0.000250114d },
            { 1353000.0d, 0.000252707d },
            { 1376000.0d, 0.000255234d },
            { 1399000.0d, 0.000257695d },
            { 1422000.0d, 0.000260088d },
            { 1445000.0d, 0.000262413d },
            { 1468000.0d, 0.000264668d },
            { 1491000.0d, 0.000266854d },
            { 1514000.0d, 0.000268968d },
            { 1537000.0d, 0.000271012d },
            { 1560000.0d, 0.000272983d },
            { 1583000.0d, 0.000274882d },
            { 1606000.0d, 0.000276708d },
            { 1629000.0d, 0.00027846d },
            { 1652000.0d, 0.000280137d },
            { 1675000.0d, 0.00028174d },
            { 1698000.0d, 0.000283268d },
            { 1721000.0d, 0.000284721d },
            { 1744000.0d, 0.000286097d },
            { 1767000.0d, 0.000287397d },
            { 1790000.0d, 0.000288621d },
            { 1813000.0d, 0.000289767d },
            { 1836000.0d, 0.000290837d },
            { 1859000.0d, 0.000291829d },
            { 1882000.0d, 0.000292744d },
            { 1905000.0d, 0.000293581d },
            { 1928000.0d, 0.00029434d },
            { 1951000.0d, 0.000295022d },
            { 1974000.0d, 0.000295626d },
            { 1997000.0d, 0.000296152d },
            { 2020000.0d, 0.0002966d },
            { 2043000.0d, 0.00029697d },
            { 2066000.0d, 0.000297263d },
            { 2089000.0d, 0.000297478d },
            { 2112000.0d, 0.000297616d },
            { 2135000.0d, 0.000297676d },
            { 2158000.0d, 0.000297659d },
            { 2181000.0d, 0.000297565d },
            { 2204000.0d, 0.000297395d },
            { 2227000.0d, 0.000297148d },
            { 2250000.0d, 0.000296827d },
            { 2273000.0d, 0.000296427d },
            { 2296000.0d, 0.000295954d },
            { 2319000.0d, 0.000295406d },
            { 2342000.0d, 0.000294784d },
            { 2365000.0d, 0.000294087d },
            { 2388000.0d, 0.000293317d },
            { 2411000.0d, 0.000292474d },
            { 2434000.0d, 0.000291559d },
            { 2457000.0d, 0.000290572d },
            { 2480000.0d, 0.000289514d },
            { 2503000.0d, 0.000288385d },
            { 2526000.0d, 0.000287186d },
            { 2549000.0d, 0.000285919d },
            { 2572000.0d, 0.000284582d },
            { 2595000.0d, 0.000283178d },
            { 2618000.0d, 0.000281707d },
            { 2641000.0d, 0.000280171d },
            { 2664000.0d, 0.000278568d },
            { 2687000.0d, 0.000276902d },
            { 2710000.0d, 0.000275172d },
            { 2733000.0d, 0.00027338d },
            { 2756000.0d, 0.000271525d },
            { 2779000.0d, 0.00026961d },
            { 2802000.0d, 0.000267635d },
            { 2825000.0d, 0.000265603d },
            { 2848000.0d, 0.000263512d },
            { 2871000.0d, 0.000261365d },
            { 2894000.0d, 0.000259162d },
            { 2917000.0d, 0.000256904d },
            { 2940000.0d, 0.000254595d },
            { 2963000.0d, 0.000252232d },
            { 2986000.0d, 0.000249819d },
            { 3009000.0d, 0.000247356d },
            { 3032000.0d, 0.000244846d },
            { 3055000.0d, 0.000242288d },
            { 3078000.0d, 0.000239685d },
            { 3101000.0d, 0.000237036d },
            { 3124000.0d, 0.000234346d },
            { 3147000.0d, 0.000231614d },
            { 3170000.0d, 0.000228841d },
            { 3193000.0d, 0.000226029d },
            { 3216000.0d, 0.000223181d },
            { 3239000.0d, 0.000220296d },
            { 3262000.0d, 0.000217377d },
            { 3285000.0d, 0.000214425d },
            { 3308000.0d, 0.000211442d },
            { 3331000.0d, 0.00020843d },
            { 3354000.0d, 0.000205389d },
            { 3377000.0d, 0.000202322d },
            { 3400000.0d, 0.000199229d },
            { 3423000.0d, 0.000196114d },
            { 3446000.0d, 0.000192978d },
            { 3469000.0d, 0.000189821d },
            { 3492000.0d, 0.000186647d },
            { 3515000.0d, 0.000183456d },
            { 3538000.0d, 0.000180251d },
            { 3561000.0d, 0.000177034d },
            { 3584000.0d, 0.000173805d },
            { 3607000.0d, 0.000170568d },
            { 3630000.0d, 0.000167323d },
            { 3653000.0d, 0.000164073d },
            { 3676000.0d, 0.00016082d },
            { 3699000.0d, 0.000157566d },
            { 3722000.0d, 0.000154312d },
            { 3745000.0d, 0.000151061d },
            { 3768000.0d, 0.000147815d },
            { 3791000.0d, 0.000144575d },
            { 3814000.0d, 0.000141344d },
            { 3837000.0d, 0.000138124d },
            { 3860000.0d, 0.000134916d },
            { 3883000.0d, 0.000131724d },
            { 3906000.0d, 0.000128549d },
            { 3929000.0d, 0.000125393d },
            { 3952000.0d, 0.000122258d },
            { 3975000.0d, 0.000119147d },
            { 3998000.0d, 0.000116062d },
            { 4021000.0d, 0.000113005d },
            { 4044000.0d, 0.000109979d },
            { 4067000.0d, 0.000106985d },
            { 4090000.0d, 0.000104026d },
            { 4113000.0d, 0.000101104d },
            { 4136000.0d, 0.0000982222d },
            { 4159000.0d, 0.0000953819d },
            { 4182000.0d, 0.000092586d },
            { 4205000.0d, 0.0000898368d },
            { 4228000.0d, 0.0000871367d },
            { 4251000.0d, 0.000084488d },
            { 4274000.0d, 0.0000818933d },
            { 4297000.0d, 0.0000793552d },
            { 4320000.0d, 0.0000768758d },
            { 4343000.0d, 0.0000744577d },
            { 4366000.0d, 0.0000721036d },
            { 4389000.0d, 0.000069816d },
            { 4412000.0d, 0.0000675973d },
            { 4435000.0d, 0.00006545d },
            { 4458000.0d, 0.0000633768d },
            { 4481000.0d, 0.0000613801d },
            { 4504000.0d, 0.0000594612d },
            { 4527000.0d, 0.0000576223d },
            { 4550000.0d, 0.0000558654d },
            { 4573000.0d, 0.000054193d },
            { 4596000.0d, 0.0000526075d },
            { 4619000.0d, 0.0000511116d },
            { 4642000.0d, 0.0000497079d },
            { 4665000.0d, 0.0000483988d },
            { 4688000.0d, 0.0000471871d },
            { 4711000.0d, 0.0000460748d },
            { 4734000.0d, 0.0000450644d },
            { 4757000.0d, 0.0000441508d },
            { 4780000.0d, 0.0000433226d },
            { 4803000.0d, 0.0000425097d },
            { 4826000.0d, 0.0000416975d },
            { 4849000.0d, 0.0000408862d },
            { 4872000.0d, 0.0000400761d },
            { 4895000.0d, 0.0000392676d },
            { 4918000.0d, 0.0000384608d },
            { 4941000.0d, 0.0000376563d },
            { 4964000.0d, 0.0000368542d },
            { 4987000.0d, 0.0000360548d },
            { 5010000.0d, 0.0000352584d },
            { 5033000.0d, 0.0000344655d },
            { 5056000.0d, 0.0000336762d },
            { 5079000.0d, 0.0000328909d },
            { 5102000.0d, 0.0000321098d },
            { 5125000.0d, 0.000031332d },
            { 5148000.0d, 0.0000305578d },
            { 5171000.0d, 0.0000297875d },
            { 5194000.0d, 0.0000290213d },
            { 5217000.0d, 0.0000282596d },
            { 5240000.0d, 0.0000275026d },
            { 5263000.0d, 0.0000267506d },
            { 5286000.0d, 0.0000260041d },
            { 5309000.0d, 0.0000252633d },
            { 5332000.0d, 0.0000245282d },
            { 5355000.0d, 0.0000237996d },
            { 5378000.0d, 0.0000230777d },
            { 5401000.0d, 0.0000223626d },
            { 5424000.0d, 0.0000216547d },
            { 5447000.0d, 0.0000209544d },
            { 5470000.0d, 0.000020262d },
            { 5493000.0d, 0.0000195778d },
            { 5516000.0d, 0.0000189021d },
            { 5539000.0d, 0.0000182353d },
            { 5562000.0d, 0.0000175776d },
            { 5585000.0d, 0.0000169295d },
            { 5608000.0d, 0.0000162912d },
            { 5631000.0d, 0.0000156631d },
            { 5654000.0d, 0.0000150455d },
            { 5677000.0d, 0.0000144387d },
            { 5700000.0d, 0.0000138431d },
            { 5723000.0d, 0.0000132591d },
            { 5746000.0d, 0.0000126868d },
            { 5769000.0d, 0.0000121261d },
            { 5792000.0d, 0.0000115769d },
            { 5815000.0d, 0.0000110396d },
            { 5838000.0d, 0.0000105145d },
            { 5861000.0d, 0.0000100019d },
            { 5884000.0d, 0.00000950232d },
            { 5907000.0d, 0.00000901593d },
            { 5930000.0d, 0.00000854313d },
            { 5953000.0d, 0.00000808424d },
            { 5976000.0d, 0.00000763963d },
            { 5999000.0d, 0.00000720963d },
            { 6022000.0d, 0.0000067946d },
            { 6045000.0d, 0.00000639489d },
            { 6068000.0d, 0.00000601086d },
            { 6091000.0d, 0.00000564286d },
            { 6114000.0d, 0.00000529124d },
            { 6137000.0d, 0.00000495634d },
            { 6160000.0d, 0.00000463741d },
            { 6183000.0d, 0.00000433299d },
            { 6206000.0d, 0.00000404339d },
            { 6229000.0d, 0.00000376861d },
            { 6252000.0d, 0.00000350845d },
            { 6275000.0d, 0.00000326321d },
            { 6298000.0d, 0.00000303319d },
            { 6321000.0d, 0.0000028187d },
            { 6344000.0d, 0.00000261919d },
            { 6367000.0d, 0.00000243163d },
            { 6390000.0d, 0.00000225593d },
            { 6413000.0d, 0.00000209238d },
            { 6436000.0d, 0.00000194123d },
            { 6459000.0d, 0.00000180278d },
            { 6482000.0d, 0.00000167671d },
            { 6505000.0d, 0.00000156264d },
            { 6528000.0d, 0.00000146083d },
            { 6551000.0d, 0.00000137145d },
            { 6574000.0d, 0.00000128833d },
            { 6597000.0d, 0.00000120634d },
            { 6620000.0d, 0.0000011256d },
            { 6643000.0d, 0.00000104626d },
            { 6666000.0d, 0.000000968495d },
            { 6689000.0d, 0.000000892461d },
            { 6712000.0d, 0.000000818337d },
            { 6735000.0d, 0.000000746314d },
            { 6758000.0d, 0.000000676549d },
            { 6781000.0d, 0.000000608765d },
            { 6804000.0d, 0.000000543043d },
            { 6827000.0d, 0.000000479618d },
            { 6850000.0d, 0.000000418739d },
            { 6873000.0d, 0.00000036067d },
            { 6896000.0d, 0.000000305693d },
            { 6919000.0d, 0.000000254104d },
            { 6942000.0d, 0.000000206218d },
            { 6965000.0d, 0.000000162368d },
            { 6988000.0d, 0.000000122904d },
            { 7011000.0d, 0.0000000881936d },
            { 7034000.0d, 0.000000058626d },
            { 7057000.0d, 0.0000000346074d },
            { 7080000.0d, 0.0000000165609d },
            { 7103000.0d, 0.00000000492253d },
            { 7126000.0d, 0.000000000123569d },
            { 7130000.0d, 0d },

        }; 
    }
}
    