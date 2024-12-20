using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Terbium141 : RadioactiveSubstance
    {
        public override string name { get; } = "Terbium141";
        public override double halfLife { get; } = 3.5d;
        public override double atomicWeight { get; } = 140.94145d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {
            { 1.0d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Europium141()), new(1.0d, new BetaParticle(1, betaPlusSpectrum)), new(0.03024d, new GammaParticle(59300.0, 0.02091)), new(0.0168d, new GammaParticle(59800.0, 0.02073)), new(0.01848d, new GammaParticle(85200.0, 0.01455)), new(0.00336d, new GammaParticle(91500.0, 0.01355)), new(0.00168d, new GammaParticle(94500.0, 0.01312)), new(0.07896d, new GammaParticle(113200.0, 0.01095)), new(0.07896d, new GammaParticle(131600.0, 0.00942)), new(0.14279999999999998d, new GammaParticle(136700.0, 0.00907)), new(0.03696d, new GammaParticle(145000.0, 0.00855)), new(0.0252d, new GammaParticle(173900.0, 0.00713)), new(0.14784d, new GammaParticle(198400.0, 0.00625)), new(0.00672d, new GammaParticle(206700.0, 0.006)), new(0.0084d, new GammaParticle(234500.0, 0.00529)), new(0.0084d, new GammaParticle(248800.0, 0.00498)), new(0.1176d, new GammaParticle(258200.0, 0.0048)), new(0.04872d, new GammaParticle(268300.0, 0.00462)), new(0.168d, new GammaParticle(293300.0, 0.00423)), new(0.16296d, new GammaParticle(343600.0, 0.00361)), new(0.04872d, new GammaParticle(379200.0, 0.00327)), new(0.01848d, new GammaParticle(389000.0, 0.00319)), new(0.04704d, new GammaParticle(402900.0, 0.00308)), new(0.01344d, new GammaParticle(406800.0, 0.00305)), new(0.01176d, new GammaParticle(426000.0, 0.00291)), new(0.03696d, new GammaParticle(463400.0, 0.00268)), new(0.08567999999999999d, new GammaParticle(475400.0, 0.00261)), new(0.05376d, new GammaParticle(480300.0, 0.00258)), new(0.06888d, new GammaParticle(492200.0, 0.00252)), new(0.0672d, new GammaParticle(494300.0, 0.00251)), new(0.09072d, new GammaParticle(500200.0, 0.00248)), new(0.04536d, new GammaParticle(517500.0, 0.0024)), new(0.0252d, new GammaParticle(530900.0, 0.00234)), new(0.0336d, new GammaParticle(554200.0, 0.00224)), new(0.03528d, new GammaParticle(585600.0, 0.00212)), new(0.01344d, new GammaParticle(611800.0, 0.00203)), new(0.04704d, new GammaParticle(617400.0, 0.00201)), new(0.01848d, new GammaParticle(636900.0, 0.00195)), new(1.7956d, new GammaParticle(511000.0, 0.00243)), new(0.069582084d, new GammaParticle(6858.0, 0.18079)), new(0.10462038607663433d, new GammaParticle(42308.0, 0.02931)), new(0.18820001093116448d, new GammaParticle(42996.0, 0.02884)), new(0.05949145991464861d, new GammaParticle(48802.0, 0.02541)), new(0.07513771387220118d, new GammaParticle(49326.0, 0.02514)), new(0.015646253957552585d, new GammaParticle(49957.0, 0.02482)) } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {
            { 0.0d, 0d },
            { 21000.0d, 0.000000084979d },
            { 42000.0d, 0.000000554208d },
            { 63000.0d, 0.0000014379d },
            { 84000.0d, 0.00000267534d },
            { 105000.0d, 0.000004176d },
            { 126000.0d, 0.00000587112d },
            { 147000.0d, 0.0000077117d },
            { 168000.0d, 0.00000966302d },
            { 189000.0d, 0.0000117002d },
            { 210000.0d, 0.0000138051d },
            { 231000.0d, 0.0000159644d },
            { 252000.0d, 0.0000181679d },
            { 273000.0d, 0.000020408d },
            { 294000.0d, 0.0000226787d },
            { 315000.0d, 0.0000249754d },
            { 336000.0d, 0.0000272941d },
            { 357000.0d, 0.0000296318d },
            { 378000.0d, 0.0000319857d },
            { 399000.0d, 0.0000343538d },
            { 420000.0d, 0.0000367341d },
            { 441000.0d, 0.000039125d },
            { 462000.0d, 0.000041525d },
            { 483000.0d, 0.0000439329d },
            { 504000.0d, 0.0000463473d },
            { 525000.0d, 0.0000487674d },
            { 546000.0d, 0.0000511921d },
            { 567000.0d, 0.0000536205d },
            { 588000.0d, 0.0000560516d },
            { 609000.0d, 0.0000584845d },
            { 630000.0d, 0.0000609188d },
            { 651000.0d, 0.0000633534d },
            { 672000.0d, 0.0000657876d },
            { 693000.0d, 0.0000682209d },
            { 714000.0d, 0.0000706524d },
            { 735000.0d, 0.0000730815d },
            { 756000.0d, 0.0000755076d },
            { 777000.0d, 0.00007793d },
            { 798000.0d, 0.0000803483d },
            { 819000.0d, 0.0000827616d },
            { 840000.0d, 0.0000851694d },
            { 861000.0d, 0.0000875711d },
            { 882000.0d, 0.0000899663d },
            { 903000.0d, 0.0000923544d },
            { 924000.0d, 0.0000947346d },
            { 945000.0d, 0.0000971068d },
            { 966000.0d, 0.0000994702d },
            { 987000.0d, 0.000101824d },
            { 1008000.0d, 0.000104168d },
            { 1031000.0d, 0.000106724d },
            { 1054000.0d, 0.000109266d },
            { 1077000.0d, 0.000111795d },
            { 1100000.0d, 0.00011431d },
            { 1123000.0d, 0.000116809d },
            { 1146000.0d, 0.000119293d },
            { 1169000.0d, 0.000121761d },
            { 1192000.0d, 0.000124213d },
            { 1215000.0d, 0.000126647d },
            { 1238000.0d, 0.000129063d },
            { 1261000.0d, 0.00013146d },
            { 1284000.0d, 0.000133839d },
            { 1307000.0d, 0.000136198d },
            { 1330000.0d, 0.000138537d },
            { 1353000.0d, 0.000140856d },
            { 1376000.0d, 0.000143154d },
            { 1399000.0d, 0.000145429d },
            { 1422000.0d, 0.000147683d },
            { 1445000.0d, 0.000149915d },
            { 1468000.0d, 0.000152123d },
            { 1491000.0d, 0.000154308d },
            { 1514000.0d, 0.000156469d },
            { 1537000.0d, 0.000158605d },
            { 1560000.0d, 0.000160717d },
            { 1583000.0d, 0.000162803d },
            { 1606000.0d, 0.000164864d },
            { 1629000.0d, 0.000166899d },
            { 1652000.0d, 0.000168907d },
            { 1675000.0d, 0.000170888d },
            { 1698000.0d, 0.000172842d },
            { 1721000.0d, 0.000174769d },
            { 1744000.0d, 0.000176667d },
            { 1767000.0d, 0.000178537d },
            { 1790000.0d, 0.000180378d },
            { 1813000.0d, 0.00018219d },
            { 1836000.0d, 0.000183973d },
            { 1859000.0d, 0.000185726d },
            { 1882000.0d, 0.000187449d },
            { 1905000.0d, 0.000189142d },
            { 1928000.0d, 0.000190804d },
            { 1951000.0d, 0.000192435d },
            { 1974000.0d, 0.000194035d },
            { 1997000.0d, 0.000195603d },
            { 2020000.0d, 0.00019714d },
            { 2043000.0d, 0.000198644d },
            { 2066000.0d, 0.000200117d },
            { 2089000.0d, 0.000201556d },
            { 2112000.0d, 0.000202963d },
            { 2135000.0d, 0.000204337d },
            { 2158000.0d, 0.000205678d },
            { 2181000.0d, 0.000206985d },
            { 2204000.0d, 0.000208259d },
            { 2227000.0d, 0.000209499d },
            { 2250000.0d, 0.000210705d },
            { 2273000.0d, 0.000211876d },
            { 2296000.0d, 0.000213013d },
            { 2319000.0d, 0.000214116d },
            { 2342000.0d, 0.000215184d },
            { 2365000.0d, 0.000216217d },
            { 2388000.0d, 0.000217215d },
            { 2411000.0d, 0.000218178d },
            { 2434000.0d, 0.000219106d },
            { 2457000.0d, 0.000219999d },
            { 2480000.0d, 0.000220856d },
            { 2503000.0d, 0.000221677d },
            { 2526000.0d, 0.000222463d },
            { 2549000.0d, 0.000223213d },
            { 2572000.0d, 0.000223927d },
            { 2595000.0d, 0.000224605d },
            { 2618000.0d, 0.000225247d },
            { 2641000.0d, 0.000225853d },
            { 2664000.0d, 0.000226423d },
            { 2687000.0d, 0.000226956d },
            { 2710000.0d, 0.000227454d },
            { 2733000.0d, 0.000227915d },
            { 2756000.0d, 0.000228341d },
            { 2779000.0d, 0.00022873d },
            { 2802000.0d, 0.000229082d },
            { 2825000.0d, 0.000229399d },
            { 2848000.0d, 0.000229679d },
            { 2871000.0d, 0.000229923d },
            { 2894000.0d, 0.00023013d },
            { 2917000.0d, 0.000230302d },
            { 2940000.0d, 0.000230437d },
            { 2963000.0d, 0.000230536d },
            { 2986000.0d, 0.000230599d },
            { 3009000.0d, 0.000230626d },
            { 3032000.0d, 0.000230617d },
            { 3055000.0d, 0.000230573d },
            { 3078000.0d, 0.000230492d },
            { 3101000.0d, 0.000230376d },
            { 3124000.0d, 0.000230224d },
            { 3147000.0d, 0.000230036d },
            { 3170000.0d, 0.000229814d },
            { 3193000.0d, 0.000229555d },
            { 3216000.0d, 0.000229262d },
            { 3239000.0d, 0.000228934d },
            { 3262000.0d, 0.00022857d },
            { 3285000.0d, 0.000228172d },
            { 3308000.0d, 0.000227739d },
            { 3331000.0d, 0.000227272d },
            { 3354000.0d, 0.000226771d },
            { 3377000.0d, 0.000226235d },
            { 3400000.0d, 0.000225665d },
            { 3423000.0d, 0.000225062d },
            { 3446000.0d, 0.000224425d },
            { 3469000.0d, 0.000223755d },
            { 3492000.0d, 0.000223051d },
            { 3515000.0d, 0.000222314d },
            { 3538000.0d, 0.000221545d },
            { 3561000.0d, 0.000220743d },
            { 3584000.0d, 0.000219909d },
            { 3607000.0d, 0.000219042d },
            { 3630000.0d, 0.000218144d },
            { 3653000.0d, 0.000217214d },
            { 3676000.0d, 0.000216253d },
            { 3699000.0d, 0.000215261d },
            { 3722000.0d, 0.000214238d },
            { 3745000.0d, 0.000213185d },
            { 3768000.0d, 0.000212101d },
            { 3791000.0d, 0.000210987d },
            { 3814000.0d, 0.000209844d },
            { 3837000.0d, 0.000208671d },
            { 3860000.0d, 0.00020747d },
            { 3883000.0d, 0.000206239d },
            { 3906000.0d, 0.000204981d },
            { 3929000.0d, 0.000203694d },
            { 3952000.0d, 0.000202379d },
            { 3975000.0d, 0.000201038d },
            { 3998000.0d, 0.000199669d },
            { 4021000.0d, 0.000198273d },
            { 4044000.0d, 0.000196851d },
            { 4067000.0d, 0.000195404d },
            { 4090000.0d, 0.000193931d },
            { 4113000.0d, 0.000192432d },
            { 4136000.0d, 0.000190909d },
            { 4159000.0d, 0.000189361d },
            { 4182000.0d, 0.00018779d },
            { 4205000.0d, 0.000186195d },
            { 4228000.0d, 0.000184577d },
            { 4251000.0d, 0.000182936d },
            { 4274000.0d, 0.000181273d },
            { 4297000.0d, 0.000179588d },
            { 4320000.0d, 0.000177881d },
            { 4343000.0d, 0.000176154d },
            { 4366000.0d, 0.000174406d },
            { 4389000.0d, 0.000172639d },
            { 4412000.0d, 0.000170851d },
            { 4435000.0d, 0.000169045d },
            { 4458000.0d, 0.00016722d },
            { 4481000.0d, 0.000165376d },
            { 4504000.0d, 0.000163516d },
            { 4527000.0d, 0.000161638d },
            { 4550000.0d, 0.000159744d },
            { 4573000.0d, 0.000157833d },
            { 4596000.0d, 0.000155907d },
            { 4619000.0d, 0.000153966d },
            { 4642000.0d, 0.00015201d },
            { 4665000.0d, 0.00015004d },
            { 4688000.0d, 0.000148057d },
            { 4711000.0d, 0.000146061d },
            { 4734000.0d, 0.000144053d },
            { 4757000.0d, 0.000142034d },
            { 4780000.0d, 0.000140002d },
            { 4803000.0d, 0.000137961d },
            { 4826000.0d, 0.000135909d },
            { 4849000.0d, 0.000133848d },
            { 4872000.0d, 0.000131779d },
            { 4895000.0d, 0.000129701d },
            { 4918000.0d, 0.000127615d },
            { 4941000.0d, 0.000125523d },
            { 4964000.0d, 0.000123424d },
            { 4987000.0d, 0.000121319d },
            { 5010000.0d, 0.00011921d },
            { 5033000.0d, 0.000117096d },
            { 5056000.0d, 0.000114978d },
            { 5079000.0d, 0.000112857d },
            { 5102000.0d, 0.000110733d },
            { 5125000.0d, 0.000108608d },
            { 5148000.0d, 0.000106482d },
            { 5171000.0d, 0.000104355d },
            { 5194000.0d, 0.000102228d },
            { 5217000.0d, 0.000100103d },
            { 5240000.0d, 0.0000979787d },
            { 5263000.0d, 0.0000958572d },
            { 5286000.0d, 0.0000937387d },
            { 5309000.0d, 0.0000916239d },
            { 5332000.0d, 0.0000895136d },
            { 5355000.0d, 0.0000874085d },
            { 5378000.0d, 0.0000853095d },
            { 5401000.0d, 0.000083217d },
            { 5424000.0d, 0.0000811322d },
            { 5447000.0d, 0.0000790554d },
            { 5470000.0d, 0.0000769877d },
            { 5493000.0d, 0.0000749296d },
            { 5516000.0d, 0.0000728822d },
            { 5539000.0d, 0.000070846d },
            { 5562000.0d, 0.0000688218d },
            { 5585000.0d, 0.0000668106d },
            { 5608000.0d, 0.000064813d },
            { 5631000.0d, 0.0000628299d },
            { 5654000.0d, 0.000060862d },
            { 5677000.0d, 0.0000589103d },
            { 5700000.0d, 0.0000569755d },
            { 5723000.0d, 0.0000550584d },
            { 5746000.0d, 0.0000531599d },
            { 5769000.0d, 0.0000512808d },
            { 5792000.0d, 0.0000494219d },
            { 5815000.0d, 0.0000475842d },
            { 5838000.0d, 0.0000457684d },
            { 5861000.0d, 0.0000439754d },
            { 5884000.0d, 0.0000422061d },
            { 5907000.0d, 0.0000404615d },
            { 5930000.0d, 0.0000387422d },
            { 5953000.0d, 0.0000370493d },
            { 5976000.0d, 0.0000353836d },
            { 5999000.0d, 0.000033746d },
            { 6022000.0d, 0.0000321374d },
            { 6045000.0d, 0.0000305588d },
            { 6068000.0d, 0.000029011d },
            { 6091000.0d, 0.0000274949d },
            { 6114000.0d, 0.0000260115d },
            { 6137000.0d, 0.0000245617d },
            { 6160000.0d, 0.0000231465d },
            { 6183000.0d, 0.0000217667d },
            { 6206000.0d, 0.0000204234d },
            { 6229000.0d, 0.0000191174d },
            { 6252000.0d, 0.0000178497d },
            { 6275000.0d, 0.0000166213d },
            { 6298000.0d, 0.0000154331d },
            { 6321000.0d, 0.0000142861d },
            { 6344000.0d, 0.0000131813d },
            { 6367000.0d, 0.0000121196d },
            { 6390000.0d, 0.000011102d },
            { 6413000.0d, 0.0000101296d },
            { 6436000.0d, 0.00000920314d },
            { 6459000.0d, 0.00000832375d },
            { 6482000.0d, 0.00000749237d },
            { 6505000.0d, 0.00000671d },
            { 6528000.0d, 0.00000597758d },
            { 6551000.0d, 0.00000529461d },
            { 6574000.0d, 0.00000465954d },
            { 6597000.0d, 0.0000040714d },
            { 6620000.0d, 0.00000353088d },
            { 6643000.0d, 0.00000303885d },
            { 6666000.0d, 0.00000259613d },
            { 6689000.0d, 0.00000220116d },
            { 6712000.0d, 0.00000185026d },
            { 6735000.0d, 0.00000154358d },
            { 6758000.0d, 0.00000128021d },
            { 6781000.0d, 0.00000105226d },
            { 6804000.0d, 0.00000084886d },
            { 6827000.0d, 0.000000670349d },
            { 6850000.0d, 0.000000517138d },
            { 6873000.0d, 0.00000038962d },
            { 6896000.0d, 0.000000288144d },
            { 6919000.0d, 0.000000210263d },
            { 6942000.0d, 0.000000146906d },
            { 6965000.0d, 0.0000000968676d },
            { 6988000.0d, 0.0000000603266d },
            { 7011000.0d, 0.0000000372265d },
            { 7034000.0d, 0.0000000219946d },
            { 7057000.0d, 0.0000000107117d },
            { 7080000.0d, 0.00000000342893d },
            { 7103000.0d, 0.000000000184581d },
            { 7110000.0d, 0d },

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    