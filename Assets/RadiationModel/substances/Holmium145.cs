using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Holmium145 : RadioactiveSubstance
    {
        public override string name { get; } = "Holmium145";
        public override double halfLife { get; } = 2.4d;
        public override double atomicWeight { get; } = 144.94727d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {
            { 1.0d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Terbium145()), new(1.0d, new BetaParticle(1, betaPlusSpectrum)), new(0.0225d, new GammaParticle(66300.0, 0.0187)), new(0.0075d, new GammaParticle(249200.0, 0.00498)), new(0.0375d, new GammaParticle(309100.0, 0.00401)), new(0.1425d, new GammaParticle(312900.0, 0.00396)), new(0.018000000000000002d, new GammaParticle(315100.0, 0.00393)), new(0.012d, new GammaParticle(316600.0, 0.00392)), new(0.135d, new GammaParticle(334100.0, 0.00371)), new(0.15d, new GammaParticle(339800.0, 0.00365)), new(0.0225d, new GammaParticle(387600.0, 0.0032)), new(0.1275d, new GammaParticle(401800.0, 0.00309)), new(0.018000000000000002d, new GammaParticle(498300.0, 0.00249)), new(0.03d, new GammaParticle(543200.0, 0.00228)), new(0.0225d, new GammaParticle(563300.0, 0.0022)), new(0.0225d, new GammaParticle(622100.0, 0.00199)), new(0.03d, new GammaParticle(700500.0, 0.00177)), new(0.0075d, new GammaParticle(852000.0, 0.00146)), new(1.21d, new GammaParticle(511000.0, 0.00243)), new(0.034d, new GammaParticle(7384.0, 0.16791)), new(0.046d, new GammaParticle(45207.0, 0.02743)), new(0.083d, new GammaParticle(45998.0, 0.02695)), new(0.027000000000000003d, new GammaParticle(52220.0, 0.02374)), new(0.033d, new GammaParticle(52791.0, 0.02349)), new(0.0069d, new GammaParticle(53478.0, 0.02318)) } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {
            { 0.0d, 0d },
            { 23000.0d, 0.0000000509586d },
            { 46000.0d, 0.000000333571d },
            { 69000.0d, 0.000000858472d },
            { 92000.0d, 0.00000158955d },
            { 115000.0d, 0.00000247087d },
            { 138000.0d, 0.00000346192d },
            { 161000.0d, 0.0000045346d },
            { 184000.0d, 0.00000566928d },
            { 207000.0d, 0.00000685193d },
            { 230000.0d, 0.00000807257d },
            { 253000.0d, 0.0000093241d },
            { 276000.0d, 0.0000106009d },
            { 299000.0d, 0.0000118987d },
            { 322000.0d, 0.0000132143d },
            { 345000.0d, 0.000014545d },
            { 368000.0d, 0.0000158889d },
            { 391000.0d, 0.0000172441d },
            { 414000.0d, 0.0000186092d },
            { 437000.0d, 0.0000199831d },
            { 460000.0d, 0.0000213648d },
            { 483000.0d, 0.0000227534d },
            { 506000.0d, 0.000024148d },
            { 529000.0d, 0.000025548d },
            { 552000.0d, 0.0000269525d },
            { 575000.0d, 0.0000283612d },
            { 598000.0d, 0.0000297733d },
            { 621000.0d, 0.0000311885d },
            { 644000.0d, 0.000032606d },
            { 667000.0d, 0.0000340256d },
            { 690000.0d, 0.0000354468d },
            { 713000.0d, 0.000036869d },
            { 736000.0d, 0.0000382919d },
            { 759000.0d, 0.0000397151d },
            { 782000.0d, 0.0000411382d },
            { 805000.0d, 0.0000425608d },
            { 828000.0d, 0.0000439825d },
            { 851000.0d, 0.0000454029d },
            { 874000.0d, 0.0000468217d },
            { 897000.0d, 0.0000482386d },
            { 920000.0d, 0.000049653d },
            { 943000.0d, 0.0000510649d },
            { 966000.0d, 0.0000524738d },
            { 989000.0d, 0.0000538793d },
            { 1012000.0d, 0.0000552811d },
            { 1038000.0d, 0.000056861d },
            { 1064000.0d, 0.0000584353d },
            { 1090000.0d, 0.0000600038d },
            { 1116000.0d, 0.0000615658d },
            { 1142000.0d, 0.0000631209d },
            { 1168000.0d, 0.0000646688d },
            { 1194000.0d, 0.000066209d },
            { 1220000.0d, 0.0000677412d },
            { 1246000.0d, 0.0000692648d },
            { 1272000.0d, 0.0000707795d },
            { 1298000.0d, 0.000072285d },
            { 1324000.0d, 0.0000737808d },
            { 1350000.0d, 0.0000752665d },
            { 1376000.0d, 0.0000767419d },
            { 1402000.0d, 0.0000782066d },
            { 1428000.0d, 0.00007966d },
            { 1454000.0d, 0.0000811021d },
            { 1480000.0d, 0.0000825323d },
            { 1506000.0d, 0.0000839504d },
            { 1532000.0d, 0.000085356d },
            { 1558000.0d, 0.0000867488d },
            { 1584000.0d, 0.0000881286d },
            { 1610000.0d, 0.0000894948d },
            { 1636000.0d, 0.0000908472d },
            { 1662000.0d, 0.0000921858d },
            { 1688000.0d, 0.0000935099d },
            { 1714000.0d, 0.0000948195d },
            { 1740000.0d, 0.0000961141d },
            { 1766000.0d, 0.0000973935d },
            { 1792000.0d, 0.0000986575d },
            { 1818000.0d, 0.0000999058d },
            { 1844000.0d, 0.000101138d },
            { 1870000.0d, 0.000102354d },
            { 1896000.0d, 0.000103554d },
            { 1922000.0d, 0.000104737d },
            { 1948000.0d, 0.000105902d },
            { 1974000.0d, 0.000107051d },
            { 2000000.0d, 0.000108182d },
            { 2026000.0d, 0.000109296d },
            { 2052000.0d, 0.000110392d },
            { 2078000.0d, 0.000111469d },
            { 2104000.0d, 0.000112529d },
            { 2130000.0d, 0.00011357d },
            { 2156000.0d, 0.000114592d },
            { 2182000.0d, 0.000115596d },
            { 2208000.0d, 0.00011658d },
            { 2234000.0d, 0.000117545d },
            { 2260000.0d, 0.000118491d },
            { 2286000.0d, 0.000119417d },
            { 2312000.0d, 0.000120324d },
            { 2338000.0d, 0.00012121d },
            { 2364000.0d, 0.000122077d },
            { 2390000.0d, 0.000122923d },
            { 2416000.0d, 0.000123749d },
            { 2442000.0d, 0.000124555d },
            { 2468000.0d, 0.00012534d },
            { 2494000.0d, 0.000126105d },
            { 2520000.0d, 0.000126848d },
            { 2546000.0d, 0.000127571d },
            { 2572000.0d, 0.000128272d },
            { 2598000.0d, 0.000128953d },
            { 2624000.0d, 0.000129612d },
            { 2650000.0d, 0.00013025d },
            { 2676000.0d, 0.000130866d },
            { 2702000.0d, 0.000131461d },
            { 2728000.0d, 0.000132034d },
            { 2754000.0d, 0.000132585d },
            { 2780000.0d, 0.000133115d },
            { 2806000.0d, 0.000133623d },
            { 2832000.0d, 0.000134109d },
            { 2858000.0d, 0.000134573d },
            { 2884000.0d, 0.000135015d },
            { 2910000.0d, 0.000135435d },
            { 2936000.0d, 0.000135832d },
            { 2962000.0d, 0.000136208d },
            { 2988000.0d, 0.000136561d },
            { 3014000.0d, 0.000136893d },
            { 3040000.0d, 0.000137202d },
            { 3066000.0d, 0.000137488d },
            { 3092000.0d, 0.000137753d },
            { 3118000.0d, 0.000137995d },
            { 3144000.0d, 0.000138215d },
            { 3170000.0d, 0.000138413d },
            { 3196000.0d, 0.000138588d },
            { 3222000.0d, 0.000138741d },
            { 3248000.0d, 0.000138872d },
            { 3274000.0d, 0.000138981d },
            { 3300000.0d, 0.000139067d },
            { 3326000.0d, 0.000139132d },
            { 3352000.0d, 0.000139174d },
            { 3378000.0d, 0.000139194d },
            { 3404000.0d, 0.000139192d },
            { 3430000.0d, 0.000139168d },
            { 3456000.0d, 0.000139122d },
            { 3482000.0d, 0.000139054d },
            { 3508000.0d, 0.000138964d },
            { 3534000.0d, 0.000138852d },
            { 3560000.0d, 0.000138719d },
            { 3586000.0d, 0.000138564d },
            { 3612000.0d, 0.000138387d },
            { 3638000.0d, 0.000138189d },
            { 3664000.0d, 0.000137969d },
            { 3690000.0d, 0.000137728d },
            { 3716000.0d, 0.000137466d },
            { 3742000.0d, 0.000137183d },
            { 3768000.0d, 0.000136878d },
            { 3794000.0d, 0.000136553d },
            { 3820000.0d, 0.000136207d },
            { 3846000.0d, 0.000135841d },
            { 3872000.0d, 0.000135453d },
            { 3898000.0d, 0.000135045d },
            { 3924000.0d, 0.000134617d },
            { 3950000.0d, 0.000134169d },
            { 3976000.0d, 0.000133701d },
            { 4002000.0d, 0.000133213d },
            { 4028000.0d, 0.000132705d },
            { 4054000.0d, 0.000132177d },
            { 4080000.0d, 0.00013163d },
            { 4106000.0d, 0.000131064d },
            { 4132000.0d, 0.000130478d },
            { 4158000.0d, 0.000129874d },
            { 4184000.0d, 0.000129251d },
            { 4210000.0d, 0.000128609d },
            { 4236000.0d, 0.000127949d },
            { 4262000.0d, 0.000127271d },
            { 4288000.0d, 0.000126574d },
            { 4314000.0d, 0.00012586d },
            { 4340000.0d, 0.000125128d },
            { 4366000.0d, 0.000124379d },
            { 4392000.0d, 0.000123612d },
            { 4418000.0d, 0.000122829d },
            { 4444000.0d, 0.000122029d },
            { 4470000.0d, 0.000121212d },
            { 4496000.0d, 0.000120378d },
            { 4522000.0d, 0.000119529d },
            { 4548000.0d, 0.000118664d },
            { 4574000.0d, 0.000117783d },
            { 4600000.0d, 0.000116886d },
            { 4626000.0d, 0.000115975d },
            { 4652000.0d, 0.000115049d },
            { 4678000.0d, 0.000114108d },
            { 4704000.0d, 0.000113152d },
            { 4730000.0d, 0.000112183d },
            { 4756000.0d, 0.000111199d },
            { 4782000.0d, 0.000110202d },
            { 4808000.0d, 0.000109192d },
            { 4834000.0d, 0.000108168d },
            { 4860000.0d, 0.000107132d },
            { 4886000.0d, 0.000106083d },
            { 4912000.0d, 0.000105023d },
            { 4938000.0d, 0.00010395d },
            { 4964000.0d, 0.000102866d },
            { 4990000.0d, 0.00010177d },
            { 5016000.0d, 0.000100664d },
            { 5042000.0d, 0.0000995466d },
            { 5068000.0d, 0.0000984193d },
            { 5094000.0d, 0.0000972818d },
            { 5120000.0d, 0.0000961347d },
            { 5146000.0d, 0.0000949782d },
            { 5172000.0d, 0.0000938127d },
            { 5198000.0d, 0.0000926385d },
            { 5224000.0d, 0.0000914561d },
            { 5250000.0d, 0.0000902657d },
            { 5276000.0d, 0.0000890675d },
            { 5302000.0d, 0.0000878622d },
            { 5328000.0d, 0.0000866499d },
            { 5354000.0d, 0.0000854309d },
            { 5380000.0d, 0.0000842059d },
            { 5406000.0d, 0.000082975d },
            { 5432000.0d, 0.0000817387d },
            { 5458000.0d, 0.0000804974d },
            { 5484000.0d, 0.0000792514d },
            { 5510000.0d, 0.0000780011d },
            { 5536000.0d, 0.0000767468d },
            { 5562000.0d, 0.000075489d },
            { 5588000.0d, 0.0000742282d },
            { 5614000.0d, 0.0000729647d },
            { 5640000.0d, 0.0000716989d },
            { 5666000.0d, 0.0000704312d },
            { 5692000.0d, 0.000069162d },
            { 5718000.0d, 0.0000678919d },
            { 5744000.0d, 0.000066621d },
            { 5770000.0d, 0.00006535d },
            { 5796000.0d, 0.0000640793d },
            { 5822000.0d, 0.0000628092d },
            { 5848000.0d, 0.0000615403d },
            { 5874000.0d, 0.0000602729d },
            { 5900000.0d, 0.0000590075d },
            { 5926000.0d, 0.0000577446d },
            { 5952000.0d, 0.0000564846d },
            { 5978000.0d, 0.000055228d },
            { 6004000.0d, 0.0000539752d },
            { 6030000.0d, 0.0000527268d },
            { 6056000.0d, 0.0000514832d },
            { 6082000.0d, 0.0000502448d },
            { 6108000.0d, 0.0000490121d },
            { 6134000.0d, 0.0000477857d },
            { 6160000.0d, 0.000046566d },
            { 6186000.0d, 0.0000453535d },
            { 6212000.0d, 0.0000441487d },
            { 6238000.0d, 0.0000429521d },
            { 6264000.0d, 0.0000417642d },
            { 6290000.0d, 0.0000405855d },
            { 6316000.0d, 0.0000394165d },
            { 6342000.0d, 0.0000382578d },
            { 6368000.0d, 0.0000371098d },
            { 6394000.0d, 0.0000359731d },
            { 6420000.0d, 0.0000348482d },
            { 6446000.0d, 0.0000337356d },
            { 6472000.0d, 0.0000326358d },
            { 6498000.0d, 0.0000315495d },
            { 6524000.0d, 0.0000304771d },
            { 6550000.0d, 0.0000294192d },
            { 6576000.0d, 0.0000283763d },
            { 6602000.0d, 0.0000273489d },
            { 6628000.0d, 0.0000263378d },
            { 6654000.0d, 0.0000253432d },
            { 6680000.0d, 0.000024366d },
            { 6706000.0d, 0.0000234065d },
            { 6732000.0d, 0.0000224654d },
            { 6758000.0d, 0.0000215432d },
            { 6784000.0d, 0.0000206405d },
            { 6810000.0d, 0.0000197579d },
            { 6836000.0d, 0.0000188959d },
            { 6862000.0d, 0.0000180552d },
            { 6888000.0d, 0.0000172361d },
            { 6914000.0d, 0.0000164395d },
            { 6940000.0d, 0.0000156658d },
            { 6966000.0d, 0.0000149127d },
            { 6992000.0d, 0.0000141753d },
            { 7018000.0d, 0.0000134536d },
            { 7044000.0d, 0.000012748d },
            { 7070000.0d, 0.0000120591d },
            { 7096000.0d, 0.0000113872d },
            { 7122000.0d, 0.0000107329d },
            { 7148000.0d, 0.0000100965d },
            { 7174000.0d, 0.00000947858d },
            { 7200000.0d, 0.00000887949d },
            { 7226000.0d, 0.00000829972d },
            { 7252000.0d, 0.00000773971d },
            { 7278000.0d, 0.00000719969d },
            { 7304000.0d, 0.00000667748d },
            { 7330000.0d, 0.00000617271d },
            { 7356000.0d, 0.00000568579d },
            { 7382000.0d, 0.00000521712d },
            { 7408000.0d, 0.0000047671d },
            { 7434000.0d, 0.00000433616d },
            { 7460000.0d, 0.00000392469d },
            { 7486000.0d, 0.00000353312d },
            { 7512000.0d, 0.00000316185d },
            { 7538000.0d, 0.00000281129d },
            { 7564000.0d, 0.00000248187d },
            { 7590000.0d, 0.00000217397d },
            { 7616000.0d, 0.00000188801d },
            { 7642000.0d, 0.00000162438d },
            { 7668000.0d, 0.00000138299d },
            { 7694000.0d, 0.0000011605d },
            { 7720000.0d, 0.000000956452d },
            { 7746000.0d, 0.000000771172d },
            { 7772000.0d, 0.000000604999d },
            { 7798000.0d, 0.000000458265d },
            { 7824000.0d, 0.000000331299d },
            { 7850000.0d, 0.000000224424d },
            { 7876000.0d, 0.000000137957d },
            { 7902000.0d, 0.0000000722006d },
            { 7928000.0d, 0.0000000274362d },
            { 7954000.0d, 0.00000000389644d },
            { 7969800.0d, 0d },

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    