using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Strontium85m : RadioactiveSubstance
    {
        public override string name { get; } = "Strontium85m";
        public override double halfLife { get; } = 4057.8d;
        public override double atomicWeight { get; } = 84.91319d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {
            { 0.866d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Strontium85()), new(4.2e-08d, new GammaParticle(6920.0, 0.17917)), new(0.8390000000000001d, new GammaParticle(231860.0, 0.00535)), new(0.0027500000000000003d, new GammaParticle(238780.0, 0.00519)), new(0.01894497553828d, new GammaParticle(1890.0, 0.656)), new(0.004235598928209277d, new GammaParticle(14098.0, 0.08794)), new(0.008137557979268543d, new GammaParticle(14165.0, 0.08753)), new(0.0020092692854178583d, new GammaParticle(15898.0, 0.07799)), new(0.00227047429252218d, new GammaParticle(15955.0, 0.07771)), new(0.0002612050071043216d, new GammaParticle(16085.0, 0.07708)) } },
            { 0.134d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Rubidium85()), new(0.0015d, new GammaParticle(129820.0, 0.00955)), new(0.128d, new GammaParticle(151194.0, 0.0082)), new(4e-06d, new GammaParticle(281010.0, 0.00441)), new(0.000107d, new GammaParticle(450790.0, 0.00275)), new(8.7e-06d, new GammaParticle(580640.0, 0.00214)), new(0.000146d, new GammaParticle(731797.0, 0.00169)), new(2.9999999999999997e-06d, new GammaParticle(768500.0, 0.00161)), new(1e-06d, new GammaParticle(919800.0, 0.00135)), new(0.00362285352547425d, new GammaParticle(1767.0, 0.70166)), new(0.024034544092652266d, new GammaParticle(13336.0, 0.09297)), new(0.04626476244976375d, new GammaParticle(13396.0, 0.09255)), new(0.011263007177225792d, new GammaParticle(15021.0, 0.08254)), new(0.012569516009783985d, new GammaParticle(15070.0, 0.08227)), new(0.001306508832558192d, new GammaParticle(15187.0, 0.08164)) } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {
            { 0.0d, 0d },
            { 400.0d, 0.0000000000461711d },
            { 800.0d, 0.000000000128613d },
            { 1200.0d, 0.000000000263449d },
            { 1600.0d, 0.000000000461733d },
            { 2000.0d, 0.000000000733773d },
            { 2400.0d, 0.00000000108907d },
            { 2800.0d, 0.00000000153627d },
            { 3200.0d, 0.00000000208311d },
            { 3600.0d, 0.00000000273639d },
            { 4000.0d, 0.00000000350207d },
            { 4400.0d, 0.00000000438518d },
            { 4800.0d, 0.00000000538995d },
            { 5200.0d, 0.00000000651981d },
            { 5600.0d, 0.00000000777743d },
            { 6000.0d, 0.0000000091648d },
            { 6400.0d, 0.0000000106832d },
            { 6800.0d, 0.0000000123335d },
            { 7200.0d, 0.0000000141158d },
            { 7600.0d, 0.0000000160298d },
            { 8000.0d, 0.0000000180747d },
            { 8400.0d, 0.0000000202495d },
            { 8800.0d, 0.0000000225524d },
            { 9200.0d, 0.0000000249816d },
            { 9600.0d, 0.000000027535d },
            { 10000.0d, 0.0000000302102d },
            { 10400.0d, 0.0000000330043d },
            { 10800.0d, 0.0000000359146d },
            { 11200.0d, 0.000000038938d },
            { 11600.0d, 0.0000000420713d },
            { 12000.0d, 0.0000000453111d },
            { 12400.0d, 0.0000000486539d },
            { 12800.0d, 0.0000000520963d },
            { 13200.0d, 0.0000000556345d },
            { 13600.0d, 0.0000000592648d },
            { 14000.0d, 0.0000000629837d },
            { 14400.0d, 0.0000000667871d },
            { 14800.0d, 0.0000000706715d },
            { 15200.0d, 0.0000000746329d },
            { 15600.0d, 0.0000000786675d },
            { 16000.0d, 0.0000000827716d },
            { 16400.0d, 0.0000000869413d },
            { 16800.0d, 0.0000000911729d },
            { 17200.0d, 0.0000000954627d },
            { 17600.0d, 0.0000000998069d },
            { 18000.0d, 0.000000104202d },
            { 18400.0d, 0.000000108644d },
            { 18800.0d, 0.00000011313d },
            { 19200.0d, 0.000000117655d },
            { 19600.0d, 0.000000122217d },
            { 20000.0d, 0.000000126813d },
            { 20400.0d, 0.000000131438d },
            { 20800.0d, 0.000000136089d },
            { 21200.0d, 0.000000140764d },
            { 21600.0d, 0.000000145459d },
            { 22000.0d, 0.00000015017d },
            { 22400.0d, 0.000000154896d },
            { 22800.0d, 0.000000159632d },
            { 23200.0d, 0.000000164376d },
            { 23600.0d, 0.000000169125d },
            { 24000.0d, 0.000000173876d },
            { 24400.0d, 0.000000178627d },
            { 24800.0d, 0.000000183375d },
            { 25200.0d, 0.000000188117d },
            { 25600.0d, 0.00000019285d },
            { 26000.0d, 0.000000197573d },
            { 26400.0d, 0.000000202282d },
            { 26800.0d, 0.000000206976d },
            { 27200.0d, 0.000000211652d },
            { 27600.0d, 0.000000216308d },
            { 28000.0d, 0.000000220942d },
            { 28400.0d, 0.000000225551d },
            { 28800.0d, 0.000000230134d },
            { 29200.0d, 0.000000234689d },
            { 29600.0d, 0.000000239213d },
            { 30000.0d, 0.000000243705d },
            { 30400.0d, 0.000000248163d },
            { 30800.0d, 0.000000252586d },
            { 31200.0d, 0.000000256971d },
            { 31600.0d, 0.000000261316d },
            { 32000.0d, 0.000000265622d },
            { 32400.0d, 0.000000269884d },
            { 32800.0d, 0.000000274104d },
            { 33200.0d, 0.000000278278d },
            { 33600.0d, 0.000000282405d },
            { 34000.0d, 0.000000286485d },
            { 34400.0d, 0.000000290515d },
            { 34800.0d, 0.000000294495d },
            { 35200.0d, 0.000000298424d },
            { 35600.0d, 0.000000302299d },
            { 36000.0d, 0.000000306121d },
            { 36400.0d, 0.000000309887d },
            { 36800.0d, 0.000000313598d },
            { 37200.0d, 0.000000317252d },
            { 37600.0d, 0.000000320847d },
            { 38000.0d, 0.000000324384d },
            { 38400.0d, 0.000000327861d },
            { 38800.0d, 0.000000331278d },
            { 39200.0d, 0.000000334633d },
            { 39600.0d, 0.000000337926d },
            { 40000.0d, 0.000000341156d },
            { 40400.0d, 0.000000344323d },
            { 40800.0d, 0.000000347426d },
            { 41200.0d, 0.000000350464d },
            { 41600.0d, 0.000000353436d },
            { 42000.0d, 0.000000356343d },
            { 42400.0d, 0.000000359183d },
            { 42800.0d, 0.000000361956d },
            { 43200.0d, 0.000000364662d },
            { 43600.0d, 0.0000003673d },
            { 44000.0d, 0.00000036987d },
            { 44400.0d, 0.000000372371d },
            { 44800.0d, 0.000000374804d },
            { 45200.0d, 0.000000377167d },
            { 45600.0d, 0.00000037946d },
            { 46000.0d, 0.000000381684d },
            { 46400.0d, 0.000000383838d },
            { 46800.0d, 0.000000385922d },
            { 47200.0d, 0.000000387935d },
            { 47600.0d, 0.000000389878d },
            { 48000.0d, 0.000000391749d },
            { 48400.0d, 0.000000393551d },
            { 48800.0d, 0.000000395281d },
            { 49200.0d, 0.00000039694d },
            { 49600.0d, 0.000000398528d },
            { 50000.0d, 0.000000400045d },
            { 50400.0d, 0.000000401491d },
            { 50800.0d, 0.000000402866d },
            { 51200.0d, 0.00000040417d },
            { 51600.0d, 0.000000405403d },
            { 52000.0d, 0.000000406565d },
            { 52400.0d, 0.000000407656d },
            { 52800.0d, 0.000000408676d },
            { 53200.0d, 0.000000409626d },
            { 53600.0d, 0.000000410505d },
            { 54000.0d, 0.000000411314d },
            { 54400.0d, 0.000000412053d },
            { 54800.0d, 0.000000412722d },
            { 55200.0d, 0.000000413322d },
            { 55600.0d, 0.000000413851d },
            { 56000.0d, 0.000000414312d },
            { 56400.0d, 0.000000414704d },
            { 56800.0d, 0.000000415026d },
            { 57200.0d, 0.000000415281d },
            { 57600.0d, 0.000000415467d },
            { 58000.0d, 0.000000415586d },
            { 58400.0d, 0.000000415637d },
            { 58800.0d, 0.00000041562d },
            { 59200.0d, 0.000000415538d },
            { 59600.0d, 0.000000415388d },
            { 60000.0d, 0.000000415173d },
            { 60400.0d, 0.000000414892d },
            { 60800.0d, 0.000000414545d },
            { 61200.0d, 0.000000414134d },
            { 61600.0d, 0.000000413659d },
            { 62000.0d, 0.000000413119d },
            { 62400.0d, 0.000000412516d },
            { 62800.0d, 0.00000041185d },
            { 63200.0d, 0.000000411121d },
            { 63600.0d, 0.00000041033d },
            { 64000.0d, 0.000000409478d },
            { 64400.00000000001d, 0.000000408564d },
            { 64800.0d, 0.00000040759d },
            { 65200.0d, 0.000000406556d },
            { 65600.0d, 0.000000405462d },
            { 66000.0d, 0.000000404309d },
            { 66400.0d, 0.000000403098d },
            { 66800.0d, 0.000000401829d },
            { 67200.0d, 0.000000400503d },
            { 67600.0d, 0.000000399119d },
            { 68000.0d, 0.00000039768d },
            { 68400.0d, 0.000000396185d },
            { 68800.0d, 0.000000394635d },
            { 69200.0d, 0.000000393031d },
            { 69600.0d, 0.000000391373d },
            { 70000.0d, 0.000000389662d },
            { 70400.0d, 0.000000387899d },
            { 70800.0d, 0.000000386083d },
            { 71200.0d, 0.000000384217d },
            { 71600.0d, 0.0000003823d },
            { 72000.0d, 0.000000380333d },
            { 72400.0d, 0.000000378317d },
            { 72800.0d, 0.000000376253d },
            { 73200.0d, 0.00000037414d },
            { 73600.0d, 0.000000371981d },
            { 74000.0d, 0.000000369775d },
            { 74400.0d, 0.000000367523d },
            { 74800.0d, 0.000000365226d },
            { 75200.0d, 0.000000362885d },
            { 75600.0d, 0.000000360501d },
            { 76000.0d, 0.000000358073d },
            { 76400.0d, 0.000000355604d },
            { 76800.0d, 0.000000353093d },
            { 77200.0d, 0.000000350541d },
            { 77600.0d, 0.00000034795d },
            { 78000.0d, 0.000000345319d },
            { 78400.0d, 0.00000034265d },
            { 78800.0d, 0.000000339943d },
            { 79200.0d, 0.0000003372d },
            { 79600.0d, 0.00000033442d },
            { 80000.0d, 0.000000331606d },
            { 80400.0d, 0.000000328756d },
            { 80800.0d, 0.000000325873d },
            { 81200.0d, 0.000000322957d },
            { 81600.0d, 0.000000320009d },
            { 82000.0d, 0.00000031703d },
            { 82400.0d, 0.00000031402d },
            { 82800.0d, 0.000000310981d },
            { 83200.0d, 0.000000307913d },
            { 83600.0d, 0.000000304816d },
            { 84000.0d, 0.000000301693d },
            { 84400.0d, 0.000000298543d },
            { 84800.0d, 0.000000295367d },
            { 85200.0d, 0.000000292167d },
            { 85600.0d, 0.000000288943d },
            { 86000.0d, 0.000000285696d },
            { 86400.0d, 0.000000282427d },
            { 86800.0d, 0.000000279137d },
            { 87200.0d, 0.000000275826d },
            { 87600.0d, 0.000000272495d },
            { 88000.0d, 0.000000269146d },
            { 88400.0d, 0.000000265779d },
            { 88800.0d, 0.000000262395d },
            { 89200.0d, 0.000000258995d },
            { 89600.0d, 0.00000025558d },
            { 90000.0d, 0.00000025215d },
            { 90400.0d, 0.000000248707d },
            { 90800.0d, 0.000000245252d },
            { 91200.0d, 0.000000241785d },
            { 91600.0d, 0.000000238307d },
            { 92000.0d, 0.000000234819d },
            { 92400.0d, 0.000000231322d },
            { 92800.0d, 0.000000227817d },
            { 93200.0d, 0.000000224305d },
            { 93600.0d, 0.000000220787d },
            { 94000.0d, 0.000000217263d },
            { 94400.0d, 0.000000213735d },
            { 94800.0d, 0.000000210204d },
            { 95200.0d, 0.00000020667d },
            { 95600.0d, 0.000000203134d },
            { 96000.0d, 0.000000199598d },
            { 96400.0d, 0.000000196062d },
            { 96800.0d, 0.000000192527d },
            { 97200.0d, 0.000000188994d },
            { 97600.0d, 0.000000185464d },
            { 98000.0d, 0.000000181938d },
            { 98400.0d, 0.000000178417d },
            { 98800.0d, 0.000000174902d },
            { 99200.0d, 0.000000171394d },
            { 99600.0d, 0.000000167894d },
            { 100000.0d, 0.000000164402d },
            { 100400.0d, 0.00000016092d },
            { 100800.0d, 0.000000157449d },
            { 101200.0d, 0.000000153989d },
            { 101600.0d, 0.000000150542d },
            { 102000.0d, 0.000000147108d },
            { 102400.0d, 0.000000143689d },
            { 102800.0d, 0.000000140285d },
            { 103200.0d, 0.000000136898d },
            { 103600.0d, 0.000000133528d },
            { 104000.0d, 0.000000130177d },
            { 104400.0d, 0.000000126845d },
            { 104800.0d, 0.000000123533d },
            { 105200.0d, 0.000000120243d },
            { 105600.0d, 0.000000116975d },
            { 106000.0d, 0.00000011373d },
            { 106400.0d, 0.000000110509d },
            { 106800.0d, 0.000000107314d },
            { 107200.0d, 0.000000104145d },
            { 107600.0d, 0.000000101004d },
            { 108000.0d, 0.0000000978902d },
            { 108400.0d, 0.0000000948061d },
            { 108800.0d, 0.0000000917522d },
            { 109200.0d, 0.0000000887296d },
            { 109600.0d, 0.0000000857393d },
            { 110000.0d, 0.0000000827822d },
            { 110400.0d, 0.0000000798594d },
            { 110800.0d, 0.0000000769719d },
            { 111200.0d, 0.0000000741207d },
            { 111600.0d, 0.0000000713068d },
            { 112000.0d, 0.0000000685312d },
            { 112400.0d, 0.000000065795d },
            { 112800.0d, 0.0000000630991d },
            { 113200.0d, 0.0000000604446d },
            { 113600.0d, 0.0000000578325d },
            { 114000.0d, 0.0000000552639d },
            { 114400.0d, 0.0000000527396d },
            { 114800.0d, 0.0000000502608d },
            { 115200.0d, 0.0000000478285d },
            { 115600.0d, 0.0000000454438d },
            { 116000.0d, 0.0000000431075d },
            { 116400.0d, 0.0000000408209d },
            { 116800.0d, 0.0000000385849d },
            { 117200.0d, 0.0000000364005d },
            { 117600.0d, 0.0000000342688d },
            { 118000.0d, 0.0000000321908d },
            { 118400.0d, 0.0000000301676d },
            { 118800.0d, 0.0000000282001d },
            { 119200.0d, 0.0000000262895d },
            { 119600.0d, 0.0000000244368d },
            { 120000.0d, 0.000000022643d },
            { 120400.0d, 0.0000000209092d },
            { 120800.0d, 0.0000000192364d },
            { 121200.0d, 0.0000000176257d },
            { 121600.0d, 0.000000016078d },
            { 122000.0d, 0.0000000145945d },
            { 122400.0d, 0.0000000131763d },
            { 122800.0d, 0.0000000118243d },
            { 123200.0d, 0.0000000105396d },
            { 123600.0d, 0.00000000932329d },
            { 124000.0d, 0.00000000817641d },
            { 124400.0d, 0.00000000710001d },
            { 124800.0d, 0.00000000609515d },
            { 125200.0d, 0.00000000516289d },
            { 125600.0d, 0.00000000430429d },
            { 126000.0d, 0.0000000035204d },
            { 126400.0d, 0.0000000028123d },
            { 126800.0d, 0.00000000218103d },
            { 127200.0d, 0.00000000162767d },
            { 127600.0d, 0.00000000115326d },
            { 128000.0d, 0.000000000758879d },
            { 128400.0d, 0.000000000445575d },
            { 128800.00000000001d, 0.000000000214408d },
            { 129199.99999999999d, 0.000000000066426d },
            { 129600.0d, 0.00000000000266505d },
            { 129699.99999999999d, 0d },

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    