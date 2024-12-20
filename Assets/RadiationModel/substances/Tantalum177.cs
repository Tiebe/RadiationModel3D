using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Tantalum177 : RadioactiveSubstance
    {
        public override string name { get; } = "Tantalum177";
        public override double halfLife { get; } = 202896.0d;
        public override double atomicWeight { get; } = 176.94448d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {
            { 1.0d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Lutetium177()), new(1.0d, new BetaParticle(1, betaPlusSpectrum)), new(0.00023d, new GammaParticle(71641.8, 0.01731)), new(0.00014000000000000001d, new GammaParticle(96300.0, 0.01287)), new(0.00010200000000000001d, new GammaParticle(105358.9, 0.01177)), new(0.114d, new GammaParticle(112949.8, 0.01098)), new(1.6e-05d, new GammaParticle(129900.0, 0.00954)), new(0.000114d, new GammaParticle(136724.5, 0.00907)), new(8.599999999999999e-06d, new GammaParticle(142400.0, 0.00871)), new(2.8999999999999997e-05d, new GammaParticle(177000.7, 0.007)), new(4.6e-05d, new GammaParticle(197100.0, 0.00629)), new(0.015d, new GammaParticle(208366.2, 0.00595)), new(7.000000000000001e-05d, new GammaParticle(210200.0, 0.0059)), new(0.00049d, new GammaParticle(249674.2, 0.00497)), new(1.4e-05d, new GammaParticle(256900.0, 0.00483)), new(2.1000000000000002e-06d, new GammaParticle(268500.0, 0.00462)), new(8.8e-06d, new GammaParticle(283200.0, 0.00438)), new(2.1e-05d, new GammaParticle(297700.0, 0.00416)), new(7.699999999999999e-06d, new GammaParticle(311900.0, 0.00398)), new(1.05e-05d, new GammaParticle(313725.0, 0.00395)), new(3.7000000000000005e-05d, new GammaParticle(319300.0, 0.00388)), new(0.00031d, new GammaParticle(321315.9, 0.00386)), new(3e-05d, new GammaParticle(354900.0, 0.00349)), new(2.5e-06d, new GammaParticle(365100.0, 0.0034)), new(8.3e-05d, new GammaParticle(395200.0, 0.00314)), new(8.9e-06d, new GammaParticle(398300.0, 0.00311)), new(0.00049d, new GammaParticle(420800.0, 0.00295)), new(0.0016d, new GammaParticle(424600.0, 0.00292)), new(5.500000000000001e-06d, new GammaParticle(439900.0, 0.00282)), new(3.6e-05d, new GammaParticle(453200.0, 0.00274)), new(0.00049d, new GammaParticle(491500.0, 0.00252)), new(6.7e-05d, new GammaParticle(494700.0, 0.00251)), new(0.00111d, new GammaParticle(508100.0, 0.00244)), new(0.00027d, new GammaParticle(526100.0, 0.00236)), new(9.499999999999999e-05d, new GammaParticle(549600.0, 0.00226)), new(0.00015d, new GammaParticle(597700.0, 0.00207)), new(0.00034d, new GammaParticle(604400.0, 0.00205)), new(0.00046d, new GammaParticle(632900.0, 0.00196)), new(1.1900000000000001e-05d, new GammaParticle(681500.0, 0.00182)), new(0.00062d, new GammaParticle(734400.0, 0.00169)), new(0.00025d, new GammaParticle(736400.0, 0.00168)), new(0.0033d, new GammaParticle(745900.0, 0.00166)), new(1.05e-05d, new GammaParticle(760000.0, 0.00163)), new(4.3e-05d, new GammaParticle(805700.0, 0.00154)), new(0.00043d, new GammaParticle(847400.0, 0.00146)), new(1.4e-05d, new GammaParticle(873000.0, 0.00142)), new(0.0008799999999999999d, new GammaParticle(944800.0, 0.00131)), new(1.6e-05d, new GammaParticle(1002800.0, 0.00124)), new(0.0046d, new GammaParticle(1057800.0, 0.00117)), new(0.26d, new GammaParticle(9114.0, 0.13604)), new(0.25d, new GammaParticle(54608.0, 0.0227)), new(0.43d, new GammaParticle(55786.0, 0.02222)), new(0.14300000000000002d, new GammaParticle(63333.0, 0.01958)), new(0.18100000000000002d, new GammaParticle(64057.0, 0.01936)), new(0.038d, new GammaParticle(64935.0, 0.01909)) } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {
            { 0.0d, 0d },
            { 100.0d, 0.00000000000031865d },
            { 200.0d, 0.000000000000661009d },
            { 300.0d, 0.00000000000103228d },
            { 400.0d, 0.00000000000143288d },
            { 500.0d, 0.00000000000186299d },
            { 600.0d, 0.0000000000023227d },
            { 700.0d, 0.00000000000281211d },
            { 800.0d, 0.00000000000333128d },
            { 900.0d, 0.00000000000394305d },
            { 1000.0d, 0.00000000000460982d },
            { 1400.0d, 0.00000000000789289d },
            { 1800.0d, 0.0000000000123198d },
            { 2200.0d, 0.0000000000180679d },
            { 2600.0d, 0.0000000000253188d },
            { 3000.0d, 0.000000000034257d },
            { 3400.0d, 0.0000000000450693d },
            { 3800.0d, 0.0000000000579435d },
            { 4200.0d, 0.000000000073068d },
            { 4600.0d, 0.0000000000906306d },
            { 5000.0d, 0.000000000110818d },
            { 5400.0d, 0.000000000133815d },
            { 5800.0d, 0.000000000159803d },
            { 6200.0d, 0.000000000188961d },
            { 6600.0d, 0.000000000221465d },
            { 7000.0d, 0.000000000257486d },
            { 7400.0d, 0.00000000029719d },
            { 7800.0d, 0.000000000340738d },
            { 8200.0d, 0.000000000388286d },
            { 8600.0d, 0.000000000439985d },
            { 9000.0d, 0.000000000495979d },
            { 9400.0d, 0.000000000556406d },
            { 9800.0d, 0.000000000621398d },
            { 10000.0d, 0.000000000655637d },
            { 10400.0d, 0.00000000072771d },
            { 10800.0d, 0.000000000804647d },
            { 11200.0d, 0.000000000886559d },
            { 11600.0d, 0.000000000973545d },
            { 12000.0d, 0.0000000010657d },
            { 12400.0d, 0.00000000116311d },
            { 12800.0d, 0.00000000126587d },
            { 13200.0d, 0.00000000137402d },
            { 13600.0d, 0.00000000148767d },
            { 14000.0d, 0.00000000160684d },
            { 14400.0d, 0.00000000173162d },
            { 14800.0d, 0.00000000186203d },
            { 15200.0d, 0.00000000199812d },
            { 15600.0d, 0.00000000213992d },
            { 16000.0d, 0.00000000228746d },
            { 16400.0d, 0.00000000244076d },
            { 16800.0d, 0.00000000259983d },
            { 17200.0d, 0.00000000276469d },
            { 17600.0d, 0.00000000293533d },
            { 18000.0d, 0.00000000311176d },
            { 18400.0d, 0.00000000329395d },
            { 18800.0d, 0.00000000348191d },
            { 19200.0d, 0.00000000367562d },
            { 19600.0d, 0.00000000387505d },
            { 20000.0d, 0.00000000408016d },
            { 20400.0d, 0.00000000429093d },
            { 20800.0d, 0.00000000450732d },
            { 21200.0d, 0.00000000472928d },
            { 21600.0d, 0.00000000495678d },
            { 22000.0d, 0.00000000518975d },
            { 22400.0d, 0.00000000542815d },
            { 22800.0d, 0.00000000567191d },
            { 23200.0d, 0.00000000592097d },
            { 23600.0d, 0.00000000617527d },
            { 24000.0d, 0.00000000643475d },
            { 24400.0d, 0.00000000669931d },
            { 24800.0d, 0.00000000696891d },
            { 25200.0d, 0.00000000724345d },
            { 25600.0d, 0.00000000752285d },
            { 26000.0d, 0.00000000780704d },
            { 26400.0d, 0.00000000809593d },
            { 26800.0d, 0.00000000838943d },
            { 27200.0d, 0.00000000868744d },
            { 27600.0d, 0.00000000898991d },
            { 28000.0d, 0.00000000929671d },
            { 28400.0d, 0.00000000960775d },
            { 28800.0d, 0.00000000992295d },
            { 29200.0d, 0.0000000102422d },
            { 29600.0d, 0.0000000105654d },
            { 30000.0d, 0.0000000108925d },
            { 30400.0d, 0.0000000112233d },
            { 30800.0d, 0.0000000115579d },
            { 31200.0d, 0.0000000118959d },
            { 31600.0d, 0.0000000122372d },
            { 32000.0d, 0.0000000125817d },
            { 32400.0d, 0.0000000129291d },
            { 32800.0d, 0.0000000132794d },
            { 33200.0d, 0.0000000136325d },
            { 33600.0d, 0.0000000139881d },
            { 34000.0d, 0.0000000143463d },
            { 34400.0d, 0.0000000147067d },
            { 34800.0d, 0.0000000150694d },
            { 35200.0d, 0.0000000154342d },
            { 35600.0d, 0.0000000158009d },
            { 36000.0d, 0.0000000161694d },
            { 36400.0d, 0.0000000165396d },
            { 36800.0d, 0.0000000169114d },
            { 37200.0d, 0.0000000172846d },
            { 37600.0d, 0.000000017659d },
            { 38000.0d, 0.0000000180346d },
            { 38400.0d, 0.0000000184111d },
            { 38800.0d, 0.0000000187886d },
            { 39200.0d, 0.0000000191668d },
            { 39600.0d, 0.0000000195456d },
            { 40000.0d, 0.0000000199249d },
            { 40400.0d, 0.0000000203045d },
            { 40800.0d, 0.0000000206843d },
            { 41200.0d, 0.0000000210642d },
            { 41600.0d, 0.000000021444d },
            { 42000.0d, 0.0000000218236d },
            { 42400.0d, 0.000000022203d },
            { 42800.0d, 0.0000000225818d },
            { 43200.0d, 0.0000000229601d },
            { 43600.0d, 0.0000000233377d },
            { 44000.0d, 0.0000000237144d },
            { 44400.0d, 0.0000000240902d },
            { 44800.0d, 0.0000000244649d },
            { 45200.0d, 0.0000000248384d },
            { 45600.0d, 0.0000000252105d },
            { 46000.0d, 0.0000000255812d },
            { 46400.0d, 0.0000000259502d },
            { 46800.0d, 0.0000000263176d },
            { 47200.0d, 0.0000000266832d },
            { 47600.0d, 0.0000000270468d },
            { 48000.0d, 0.0000000274084d },
            { 48400.0d, 0.0000000277678d },
            { 48800.0d, 0.0000000281249d },
            { 49200.0d, 0.0000000284795d },
            { 49600.0d, 0.0000000288317d },
            { 50000.0d, 0.0000000291813d },
            { 50400.0d, 0.0000000295281d },
            { 50800.0d, 0.0000000298721d },
            { 51200.0d, 0.0000000302131d },
            { 51600.0d, 0.0000000305511d },
            { 52000.0d, 0.0000000308859d },
            { 52400.0d, 0.0000000312174d },
            { 52800.0d, 0.0000000315456d },
            { 53200.0d, 0.0000000318703d },
            { 53600.0d, 0.0000000321915d },
            { 54000.0d, 0.000000032509d },
            { 54400.0d, 0.0000000328227d },
            { 54800.0d, 0.0000000331327d },
            { 55200.0d, 0.0000000334386d },
            { 55600.0d, 0.0000000337406d },
            { 56000.0d, 0.0000000340385d },
            { 56400.0d, 0.0000000343321d },
            { 56800.0d, 0.0000000346215d },
            { 57200.0d, 0.0000000349065d },
            { 57600.0d, 0.000000035187d },
            { 58000.0d, 0.000000035463d },
            { 58400.0d, 0.0000000357344d },
            { 58800.0d, 0.0000000360012d },
            { 59200.0d, 0.0000000362631d },
            { 59600.0d, 0.0000000365203d },
            { 60000.0d, 0.0000000367725d },
            { 60400.0d, 0.0000000370198d },
            { 60800.0d, 0.000000037262d },
            { 61200.0d, 0.0000000374991d },
            { 61600.0d, 0.000000037731d },
            { 62000.0d, 0.0000000379577d },
            { 62400.0d, 0.0000000381791d },
            { 62800.0d, 0.0000000383952d },
            { 63200.0d, 0.0000000386058d },
            { 63600.0d, 0.000000038811d },
            { 64000.0d, 0.0000000390106d },
            { 64400.00000000001d, 0.0000000392046d },
            { 64800.0d, 0.0000000393931d },
            { 65200.0d, 0.0000000395758d },
            { 65600.0d, 0.0000000397528d },
            { 66000.0d, 0.0000000399241d },
            { 66400.0d, 0.0000000400895d },
            { 66800.0d, 0.0000000402491d },
            { 67200.0d, 0.0000000404028d },
            { 67600.0d, 0.0000000405505d },
            { 68000.0d, 0.0000000406923d },
            { 68400.0d, 0.0000000408281d },
            { 68800.0d, 0.0000000409578d },
            { 69200.0d, 0.0000000410814d },
            { 69600.0d, 0.000000041199d },
            { 70000.0d, 0.0000000413104d },
            { 70400.0d, 0.0000000414156d },
            { 70800.0d, 0.0000000415147d },
            { 71200.0d, 0.0000000416075d },
            { 71600.0d, 0.0000000416942d },
            { 72000.0d, 0.0000000417745d },
            { 72400.0d, 0.0000000418486d },
            { 72800.0d, 0.0000000419164d },
            { 73200.0d, 0.000000041978d },
            { 73600.0d, 0.0000000420332d },
            { 74000.0d, 0.000000042082d },
            { 74400.0d, 0.0000000421246d },
            { 74800.0d, 0.0000000421608d },
            { 75200.0d, 0.0000000421906d },
            { 75600.0d, 0.0000000422141d },
            { 76000.0d, 0.0000000422313d },
            { 76400.0d, 0.000000042242d },
            { 76800.0d, 0.0000000422465d },
            { 77200.0d, 0.0000000422445d },
            { 77600.0d, 0.0000000422362d },
            { 78000.0d, 0.0000000422216d },
            { 78400.0d, 0.0000000422006d },
            { 78800.0d, 0.0000000421733d },
            { 79200.0d, 0.0000000421396d },
            { 79600.0d, 0.0000000420996d },
            { 80000.0d, 0.0000000420534d },
            { 80400.0d, 0.0000000420008d },
            { 80800.0d, 0.000000041942d },
            { 81200.0d, 0.0000000418769d },
            { 81600.0d, 0.0000000418055d },
            { 82000.0d, 0.000000041728d },
            { 82400.0d, 0.0000000416443d },
            { 82800.0d, 0.0000000415544d },
            { 83200.0d, 0.0000000414583d },
            { 83600.0d, 0.0000000413561d },
            { 84000.0d, 0.0000000412479d },
            { 84400.0d, 0.0000000411336d },
            { 84800.0d, 0.0000000410132d },
            { 85200.0d, 0.0000000408869d },
            { 85600.0d, 0.0000000407545d },
            { 86000.0d, 0.0000000406163d },
            { 86400.0d, 0.0000000404722d },
            { 86800.0d, 0.0000000403222d },
            { 87200.0d, 0.0000000401664d },
            { 87600.0d, 0.0000000400048d },
            { 88000.0d, 0.0000000398375d },
            { 88400.0d, 0.0000000396645d },
            { 88800.0d, 0.0000000394859d },
            { 89200.0d, 0.0000000393017d },
            { 89600.0d, 0.0000000391119d },
            { 90000.0d, 0.0000000389166d },
            { 90400.0d, 0.0000000387159d },
            { 90800.0d, 0.0000000385098d },
            { 91200.0d, 0.0000000382984d },
            { 91600.0d, 0.0000000380817d },
            { 92000.0d, 0.0000000378597d },
            { 92400.0d, 0.0000000376326d },
            { 92800.0d, 0.0000000374004d },
            { 93200.0d, 0.0000000371631d },
            { 93600.0d, 0.0000000369209d },
            { 94000.0d, 0.0000000366737d },
            { 94400.0d, 0.0000000364217d },
            { 94800.0d, 0.0000000361648d },
            { 95200.0d, 0.0000000359033d },
            { 95600.0d, 0.0000000356371d },
            { 96000.0d, 0.0000000353663d },
            { 96400.0d, 0.0000000350909d },
            { 96800.0d, 0.0000000348112d },
            { 97200.0d, 0.000000034527d },
            { 97600.0d, 0.0000000342386d },
            { 98000.0d, 0.0000000339459d },
            { 98400.0d, 0.0000000336491d },
            { 98800.0d, 0.0000000333482d },
            { 99200.0d, 0.0000000330433d },
            { 99600.0d, 0.0000000327346d },
            { 100000.0d, 0.000000032422d },
            { 100400.0d, 0.0000000321056d },
            { 100800.0d, 0.0000000317856d },
            { 101200.0d, 0.000000031462d },
            { 101600.0d, 0.000000031135d },
            { 102000.0d, 0.0000000308045d },
            { 102400.0d, 0.0000000304707d },
            { 102800.0d, 0.0000000301337d },
            { 103200.0d, 0.0000000297936d },
            { 103600.0d, 0.0000000294505d },
            { 104000.0d, 0.0000000291044d },
            { 104400.0d, 0.0000000287554d },
            { 104800.0d, 0.0000000284037d },
            { 105200.0d, 0.0000000280493d },
            { 105600.0d, 0.0000000276924d },
            { 106000.0d, 0.000000027333d },
            { 106400.0d, 0.0000000269713d },
            { 106800.0d, 0.0000000266073d },
            { 107200.0d, 0.0000000262411d },
            { 107600.0d, 0.0000000258729d },
            { 108000.0d, 0.0000000255027d },
            { 108400.0d, 0.0000000251307d },
            { 108800.0d, 0.000000024757d },
            { 109200.0d, 0.0000000243816d },
            { 109600.0d, 0.0000000240047d },
            { 110000.0d, 0.0000000236264d },
            { 110400.0d, 0.0000000232467d },
            { 110800.0d, 0.0000000228659d },
            { 111200.0d, 0.000000022484d },
            { 111600.0d, 0.0000000221012d },
            { 112000.0d, 0.0000000217174d },
            { 112400.0d, 0.000000021333d },
            { 112800.0d, 0.0000000209479d },
            { 113200.0d, 0.0000000205623d },
            { 113600.0d, 0.0000000201764d },
            { 114000.0d, 0.0000000197901d },
            { 114400.0d, 0.0000000194037d },
            { 114800.0d, 0.0000000190173d },
            { 115200.0d, 0.000000018631d },
            { 115600.0d, 0.0000000182449d },
            { 116000.0d, 0.0000000178592d },
            { 116400.0d, 0.0000000174739d },
            { 116800.0d, 0.0000000170892d },
            { 117200.0d, 0.0000000167053d },
            { 117600.0d, 0.0000000163221d },
            { 118000.0d, 0.00000001594d },
            { 118400.0d, 0.000000015559d },
            { 118800.0d, 0.0000000151792d },
            { 119200.0d, 0.0000000148007d },
            { 119600.0d, 0.0000000144238d },
            { 120000.0d, 0.0000000140485d },
            { 120400.0d, 0.0000000136749d },
            { 120800.0d, 0.0000000133033d },
            { 121200.0d, 0.0000000129336d },
            { 121600.0d, 0.0000000125662d },
            { 122000.0d, 0.000000012201d },
            { 122400.0d, 0.0000000118383d },
            { 122800.0d, 0.0000000114782d },
            { 123200.0d, 0.0000000111208d },
            { 123600.0d, 0.0000000107663d },
            { 124000.0d, 0.0000000104148d },
            { 124400.0d, 0.0000000100664d },
            { 124800.0d, 0.00000000972126d },
            { 125200.0d, 0.00000000937959d },
            { 125600.0d, 0.00000000904149d },
            { 126000.0d, 0.00000000870712d },
            { 126400.0d, 0.0000000083766d },
            { 126800.0d, 0.0000000080501d },
            { 127200.0d, 0.00000000772776d },
            { 127600.0d, 0.00000000740972d },
            { 128000.0d, 0.00000000709614d },
            { 128400.0d, 0.00000000678716d },
            { 128800.00000000001d, 0.00000000648294d },
            { 129199.99999999999d, 0.00000000618362d },
            { 129600.0d, 0.00000000588936d },
            { 130000.0d, 0.00000000560031d },
            { 130400.0d, 0.00000000531662d },
            { 130800.00000000001d, 0.00000000503845d },
            { 131200.0d, 0.00000000476596d },
            { 131600.0d, 0.00000000449928d },
            { 132000.0d, 0.00000000423859d },
            { 132400.0d, 0.00000000398404d },
            { 132800.0d, 0.00000000373579d },
            { 133200.0d, 0.00000000349399d },
            { 133600.0d, 0.0000000032588d },
            { 134000.0d, 0.00000000303039d },
            { 134400.0d, 0.0000000028089d },
            { 134800.0d, 0.00000000259451d },
            { 135200.0d, 0.00000000238738d },
            { 135600.0d, 0.00000000218766d },
            { 136000.0d, 0.00000000199552d },
            { 136400.0d, 0.00000000181112d },
            { 136800.0d, 0.00000000163463d },
            { 137200.0d, 0.00000000146621d },
            { 137600.0d, 0.00000000130602d },
            { 138000.0d, 0.00000000115424d },
            { 138400.0d, 0.00000000101102d },
            { 138800.0d, 0.000000000876541d },
            { 139200.0d, 0.000000000750961d },
            { 139600.0d, 0.000000000634451d },
            { 140000.0d, 0.00000000052718d },
            { 140400.0d, 0.000000000429316d },
            { 140800.0d, 0.00000000034103d },
            { 141200.0d, 0.000000000262491d },
            { 141600.0d, 0.00000000019387d },
            { 142000.0d, 0.000000000135338d },
            { 142400.0d, 0.0000000000870654d },
            { 142800.0d, 0.0000000000492248d },
            { 143200.0d, 0.0000000000219871d },
            { 143600.0d, 0.00000000000552284d },
            { 144000.0d, 0d },

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    