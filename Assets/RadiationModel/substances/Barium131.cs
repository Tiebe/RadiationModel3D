using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Barium131 : RadioactiveSubstance
    {
        public override string name { get; } = "Barium131";
        public override double halfLife { get; } = 993600.0d;
        public override double atomicWeight { get; } = 130.90695d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {
            { 1.0d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Xenon131()), new(1.0d, new BetaParticle(1, betaPlusSpectrum)), new(0.0010608d, new GammaParticle(54887.0, 0.02259)), new(9.599999999999999e-05d, new GammaParticle(72430.0, 0.01712)), new(0.007584d, new GammaParticle(78736.0, 0.01575)), new(0.00019199999999999998d, new GammaParticle(82442.0, 0.01504)), new(3.84e-05d, new GammaParticle(89040.0, 0.01392)), new(0.006d, new GammaParticle(92288.0, 0.01343)), new(0.00021600000000000002d, new GammaParticle(117690.0, 0.01053)), new(0.29760000000000003d, new GammaParticle(123804.0, 0.01001)), new(0.000144d, new GammaParticle(128090.0, 0.00968)), new(0.021792d, new GammaParticle(133617.0, 0.00928)), new(0.00038399999999999996d, new GammaParticle(137323.0, 0.00903)), new(0.0017856d, new GammaParticle(157160.0, 0.00789)), new(0.20352d, new GammaParticle(216088.0, 0.00574)), new(0.02496d, new GammaParticle(239621.0, 0.00517)), new(0.0064800000000000005d, new GammaParticle(246858.0, 0.00502)), new(0.029615999999999996d, new GammaParticle(249435.0, 0.00497)), new(9.12e-05d, new GammaParticle(268710.0, 0.00461)), new(0.00012d, new GammaParticle(279170.0, 0.00444)), new(0.0017327999999999998d, new GammaParticle(294503.0, 0.00421)), new(3.84e-05d, new GammaParticle(297830.0, 0.00416)), new(6.384e-05d, new GammaParticle(323200.0, 0.00384)), new(0.0009551999999999999d, new GammaParticle(351202.0, 0.00353)), new(0.000168d, new GammaParticle(368964.0, 0.00336)), new(0.14400000000000002d, new GammaParticle(373256.0, 0.00332)), new(1.968e-05d, new GammaParticle(390060.0, 0.00318)), new(0.01344d, new GammaParticle(404039.0, 0.00307)), new(0.0002112d, new GammaParticle(406110.0, 0.00305)), new(2.8800000000000002e-05d, new GammaParticle(417300.0, 0.00297)), new(2.016e-05d, new GammaParticle(423690.0, 0.00293)), new(0.0009792d, new GammaParticle(427564.0, 0.0029)), new(0.00041759999999999996d, new GammaParticle(451415.0, 0.00275)), new(5.7600000000000004e-05d, new GammaParticle(458960.0, 0.0027)), new(0.000576d, new GammaParticle(461250.0, 0.00269)), new(0.00048d, new GammaParticle(462680.0, 0.00268)), new(2.3999999999999997e-05d, new GammaParticle(474200.0, 0.00261)), new(0.0033792d, new GammaParticle(480399.0, 0.00258)), new(0.021456d, new GammaParticle(486507.0, 0.00255)), new(0.48d, new GammaParticle(496321.0, 0.0025)), new(1.92e-05d, new GammaParticle(506100.0, 0.00245)), new(2.3999999999999997e-05d, new GammaParticle(517640.0, 0.0024)), new(1.4400000000000001e-05d, new GammaParticle(533680.0, 0.00232)), new(3.6e-05d, new GammaParticle(546300.0, 0.00227)), new(2.208e-05d, new GammaParticle(550460.0, 0.00225)), new(3.7919999999999996e-05d, new GammaParticle(562824.0, 0.0022)), new(0.0016128000000000002d, new GammaParticle(572697.0, 0.00216)), new(0.01224d, new GammaParticle(585031.0, 0.00212)), new(1.776e-05d, new GammaParticle(596480.0, 0.00208)), new(1.632e-05d, new GammaParticle(599940.0, 0.00207)), new(0.014736d, new GammaParticle(620094.0, 0.002)), new(3.744e-05d, new GammaParticle(630230.0, 0.00197)), new(3.552e-05d, new GammaParticle(657640.0, 0.00189)), new(6.720000000000001e-05d, new GammaParticle(661600.0, 0.00187)), new(0.0013583999999999998d, new GammaParticle(674418.0, 0.00184)), new(0.0015216d, new GammaParticle(696467.0, 0.00178)), new(7.2e-05d, new GammaParticle(703470.0, 0.00176)), new(1.2960000000000001e-05d, new GammaParticle(745570.0, 0.00166)), new(4.8e-06d, new GammaParticle(757000.0, 0.00164)), new(2.3999999999999997e-05d, new GammaParticle(785920.0, 0.00158)), new(7.2000000000000005e-06d, new GammaParticle(795850.0, 0.00156)), new(0.00035999999999999997d, new GammaParticle(797380.0, 0.00155)), new(3.696e-05d, new GammaParticle(827790.0, 0.0015)), new(0.0023424d, new GammaParticle(831583.0, 0.00149)), new(1.92e-05d, new GammaParticle(840900.0, 0.00147)), new(2.304e-05d, new GammaParticle(884580.0, 0.0014)), new(0.0004752d, new GammaParticle(914035.0, 0.00136)), new(9.12e-05d, new GammaParticle(919650.0, 0.00135)), new(0.0074399999999999996d, new GammaParticle(923866.0, 0.00134)), new(0.0003312d, new GammaParticle(954610.0, 0.0013)), new(0.0003744d, new GammaParticle(968887.0, 0.00128)), new(4.8e-06d, new GammaParticle(1037000.0, 0.0012)), new(0.0009264d, new GammaParticle(1046400.0, 0.00118)), new(0.01344d, new GammaParticle(1047601.0, 0.00118)), new(2.7360000000000002e-05d, new GammaParticle(1125970.0, 0.0011)), new(1.632e-05d, new GammaParticle(1170520.0, 0.00106)), new(1.776e-05d, new GammaParticle(1208470.0, 0.00103)), new(4.8e-06d, new GammaParticle(1218300.0, 0.00102)), new(1.104e-05d, new GammaParticle(1341980.0, 0.00092)), new(0.12298068372627814d, new GammaParticle(4749.0, 0.26107)), new(0.27888645055747924d, new GammaParticle(30625.0, 0.04048)), new(0.5152160549740981d, new GammaParticle(30973.0, 0.04003)), new(0.15052200225429735d, new GammaParticle(35089.0, 0.03533)), new(0.1872493708043459d, new GammaParticle(35414.0, 0.03501)), new(0.03672736855004855d, new GammaParticle(35818.0, 0.03462)) } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {
            { 0.0d, 0d },
            { 400.0d, 0.00000000000423974d },
            { 800.0d, 0.0000000000109396d },
            { 1200.0d, 0.0000000000212539d },
            { 1700.0d, 0.000000000040548d },
            { 2200.0d, 0.0000000000684492d },
            { 2700.0d, 0.000000000106622d },
            { 3200.0d, 0.000000000156646d },
            { 3700.0d, 0.000000000220162d },
            { 4200.0d, 0.000000000298666d },
            { 4700.0d, 0.000000000393736d },
            { 5200.0d, 0.000000000506683d },
            { 5700.0d, 0.000000000638965d },
            { 6200.0d, 0.000000000791854d },
            { 6700.0d, 0.000000000966513d },
            { 7200.0d, 0.00000000116401d },
            { 7700.0d, 0.00000000138544d },
            { 8200.0d, 0.00000000163173d },
            { 8700.0d, 0.00000000190364d },
            { 9200.0d, 0.00000000220192d },
            { 9700.0d, 0.00000000252727d },
            { 10000.0d, 0.00000000273569d },
            { 10700.0d, 0.00000000326125d },
            { 11400.0d, 0.00000000384255d },
            { 12100.0d, 0.00000000448041d },
            { 12800.0d, 0.00000000517531d },
            { 13500.0d, 0.00000000592748d },
            { 14200.0d, 0.00000000673685d },
            { 14900.0d, 0.00000000760311d },
            { 15600.0d, 0.00000000852576d },
            { 16300.0d, 0.00000000950402d },
            { 17000.0d, 0.000000010537d },
            { 17700.0d, 0.0000000116235d },
            { 18400.0d, 0.0000000127624d },
            { 19100.0d, 0.0000000139521d },
            { 19800.0d, 0.0000000151911d },
            { 20500.0d, 0.000000016478d },
            { 21200.0d, 0.0000000178106d },
            { 21900.0d, 0.0000000191873d },
            { 22600.0d, 0.0000000206061d },
            { 23300.0d, 0.0000000220651d },
            { 24000.0d, 0.0000000235622d },
            { 24700.0d, 0.000000025095d },
            { 25400.0d, 0.0000000266618d },
            { 26100.0d, 0.0000000282601d },
            { 26800.0d, 0.000000029888d },
            { 27500.0d, 0.000000031543d },
            { 28200.0d, 0.0000000332229d },
            { 28900.0d, 0.0000000349257d },
            { 29600.0d, 0.000000036649d },
            { 30300.0d, 0.0000000383906d },
            { 31000.0d, 0.0000000401482d },
            { 31700.0d, 0.0000000419199d },
            { 32400.0d, 0.0000000437033d },
            { 33100.0d, 0.0000000454962d },
            { 33800.0d, 0.0000000472967d },
            { 34500.0d, 0.0000000491026d },
            { 35200.0d, 0.0000000509118d },
            { 35900.0d, 0.0000000527223d },
            { 36600.0d, 0.0000000545321d },
            { 37300.0d, 0.0000000563394d },
            { 38000.0d, 0.0000000581421d },
            { 38700.0d, 0.0000000599385d },
            { 39400.0d, 0.0000000617266d },
            { 40100.0d, 0.0000000635048d },
            { 40800.0d, 0.0000000652712d },
            { 41500.0d, 0.0000000670242d },
            { 42200.0d, 0.0000000687622d },
            { 42900.0d, 0.0000000704836d },
            { 43600.0d, 0.0000000721868d },
            { 44300.0d, 0.0000000738702d },
            { 45000.0d, 0.0000000755326d },
            { 45700.0d, 0.0000000771723d },
            { 46400.0d, 0.0000000787883d },
            { 47100.0d, 0.0000000803789d },
            { 47800.0d, 0.0000000819431d },
            { 48500.0d, 0.0000000834795d },
            { 49200.0d, 0.0000000849872d },
            { 49900.0d, 0.0000000864649d },
            { 50600.0d, 0.0000000879115d },
            { 51300.0d, 0.0000000893261d },
            { 52000.0d, 0.0000000907076d },
            { 52700.0d, 0.0000000920551d },
            { 53400.0d, 0.0000000933677d },
            { 54100.0d, 0.0000000946447d },
            { 54800.0d, 0.0000000958853d },
            { 55500.0d, 0.0000000970884d },
            { 56200.0d, 0.0000000982536d },
            { 56900.0d, 0.0000000993801d },
            { 57600.0d, 0.000000100467d },
            { 58300.0d, 0.000000101515d },
            { 59000.0d, 0.000000102522d },
            { 59700.0d, 0.000000103488d },
            { 60400.0d, 0.000000104413d },
            { 61100.0d, 0.000000105296d },
            { 61800.0d, 0.000000106137d },
            { 62500.0d, 0.000000106935d },
            { 63200.0d, 0.000000107691d },
            { 63900.0d, 0.000000108404d },
            { 64599.99999999999d, 0.000000109073d },
            { 65300.0d, 0.000000109699d },
            { 66000.0d, 0.000000110281d },
            { 66700.0d, 0.000000110819d },
            { 67400.0d, 0.000000111314d },
            { 68100.0d, 0.000000111765d },
            { 68800.0d, 0.000000112171d },
            { 69500.0d, 0.000000112534d },
            { 70200.0d, 0.000000112853d },
            { 70900.0d, 0.000000113128d },
            { 71600.0d, 0.00000011336d },
            { 72300.0d, 0.000000113548d },
            { 73000.0d, 0.000000113692d },
            { 73700.0d, 0.000000113794d },
            { 74400.0d, 0.000000113852d },
            { 75100.0d, 0.000000113868d },
            { 75800.0d, 0.000000113842d },
            { 76500.0d, 0.000000113773d },
            { 77200.0d, 0.000000113662d },
            { 77900.0d, 0.000000113511d },
            { 78600.0d, 0.000000113318d },
            { 79300.0d, 0.000000113085d },
            { 80000.0d, 0.000000112811d },
            { 80700.0d, 0.000000112498d },
            { 81400.0d, 0.000000112146d },
            { 82100.0d, 0.000000111755d },
            { 82800.0d, 0.000000111326d },
            { 83500.0d, 0.000000110859d },
            { 84200.0d, 0.000000110356d },
            { 84900.0d, 0.000000109816d },
            { 85600.0d, 0.000000109241d },
            { 86300.0d, 0.00000010863d },
            { 87000.0d, 0.000000107985d },
            { 87700.0d, 0.000000107307d },
            { 88400.0d, 0.000000106595d },
            { 89100.0d, 0.000000105852d },
            { 89800.0d, 0.000000105077d },
            { 90500.0d, 0.000000104271d },
            { 91200.0d, 0.000000103435d },
            { 91900.0d, 0.00000010257d },
            { 92600.0d, 0.000000101677d },
            { 93300.0d, 0.000000100757d },
            { 94000.0d, 0.0000000998102d },
            { 94700.0d, 0.0000000988377d },
            { 95400.0d, 0.0000000978404d },
            { 96100.0d, 0.0000000968195d },
            { 96800.0d, 0.0000000957756d },
            { 97500.0d, 0.0000000947099d },
            { 98200.0d, 0.0000000936231d },
            { 98900.0d, 0.0000000925165d },
            { 99600.0d, 0.000000091391d },
            { 100300.0d, 0.0000000902475d },
            { 101000.0d, 0.000000089087d },
            { 101700.0d, 0.0000000879109d },
            { 102400.0d, 0.0000000867198d },
            { 103100.0d, 0.0000000855151d },
            { 103800.0d, 0.0000000842978d },
            { 104500.0d, 0.000000083069d },
            { 105200.0d, 0.0000000818296d },
            { 105900.0d, 0.0000000805813d },
            { 106600.0d, 0.0000000793246d },
            { 107300.0d, 0.000000078061d },
            { 108000.0d, 0.0000000767916d },
            { 108700.0d, 0.0000000755176d },
            { 109400.0d, 0.0000000742404d },
            { 110100.0d, 0.0000000729608d },
            { 110800.0d, 0.0000000716801d },
            { 111500.0d, 0.0000000703998d },
            { 112200.0d, 0.000000069121d },
            { 112900.0d, 0.0000000678449d },
            { 113600.0d, 0.0000000665728d },
            { 114300.0d, 0.0000000653059d },
            { 115000.0d, 0.0000000640458d },
            { 115700.0d, 0.0000000627934d },
            { 116400.0d, 0.0000000615502d },
            { 117100.0d, 0.0000000603175d },
            { 117800.0d, 0.0000000590966d },
            { 118500.0d, 0.000000057889d },
            { 119200.0d, 0.0000000566958d },
            { 119900.0d, 0.0000000555185d },
            { 120600.0d, 0.0000000543583d },
            { 121300.0d, 0.000000053217d },
            { 122000.0d, 0.0000000520955d },
            { 122700.0d, 0.0000000509954d },
            { 123400.0d, 0.0000000499182d },
            { 124100.0d, 0.0000000488651d },
            { 124800.0d, 0.0000000478377d },
            { 125500.0d, 0.0000000468374d },
            { 126200.0d, 0.0000000458656d },
            { 126900.0d, 0.0000000449238d },
            { 127600.0d, 0.0000000440133d },
            { 128300.00000000001d, 0.0000000431359d },
            { 129000.0d, 0.0000000422927d },
            { 129699.99999999999d, 0.0000000414853d },
            { 130400.0d, 0.0000000407152d },
            { 131100.0d, 0.0000000399841d },
            { 131800.0d, 0.0000000392931d },
            { 132500.0d, 0.0000000386441d },
            { 133200.0d, 0.0000000380383d },
            { 133900.0d, 0.0000000374775d },
            { 134600.0d, 0.000000036963d },
            { 135300.0d, 0.0000000364965d },
            { 136000.0d, 0.0000000360794d },
            { 136700.0d, 0.0000000357134d },
            { 137400.0d, 0.0000000353998d },
            { 138100.0d, 0.0000000351398d },
            { 138800.0d, 0.0000000348972d },
            { 139500.0d, 0.0000000346503d },
            { 140200.0d, 0.0000000343993d },
            { 140900.0d, 0.0000000341442d },
            { 141600.0d, 0.000000033885d },
            { 142300.0d, 0.0000000336219d },
            { 143000.0d, 0.0000000333549d },
            { 143700.0d, 0.0000000330841d },
            { 144400.0d, 0.0000000328096d },
            { 145100.0d, 0.0000000325314d },
            { 145800.0d, 0.0000000322496d },
            { 146500.0d, 0.0000000319644d },
            { 147200.0d, 0.0000000316758d },
            { 147900.0d, 0.0000000313837d },
            { 148600.0d, 0.0000000310885d },
            { 149300.0d, 0.0000000307901d },
            { 150000.0d, 0.0000000304886d },
            { 150700.0d, 0.0000000301841d },
            { 151400.0d, 0.0000000298767d },
            { 152100.0d, 0.0000000295664d },
            { 152800.0d, 0.0000000292534d },
            { 153500.0d, 0.0000000289377d },
            { 154200.0d, 0.0000000286194d },
            { 154900.0d, 0.0000000282986d },
            { 155600.0d, 0.0000000279754d },
            { 156300.0d, 0.0000000276499d },
            { 157000.0d, 0.0000000273221d },
            { 157700.0d, 0.0000000269922d },
            { 158400.0d, 0.0000000266601d },
            { 159100.0d, 0.0000000263262d },
            { 159800.0d, 0.0000000259904d },
            { 160500.0d, 0.0000000256528d },
            { 161200.0d, 0.0000000253134d },
            { 161900.0d, 0.0000000249724d },
            { 162600.0d, 0.0000000246299d },
            { 163300.0d, 0.0000000242859d },
            { 164000.0d, 0.0000000239406d },
            { 164700.0d, 0.0000000235942d },
            { 165400.0d, 0.0000000232465d },
            { 166100.0d, 0.0000000228978d },
            { 166800.0d, 0.000000022548d },
            { 167500.0d, 0.0000000221974d },
            { 168200.0d, 0.000000021846d },
            { 168900.0d, 0.0000000214941d },
            { 169600.0d, 0.0000000211414d },
            { 170300.0d, 0.0000000207883d },
            { 171000.0d, 0.0000000204348d },
            { 171700.0d, 0.0000000200809d },
            { 172400.0d, 0.0000000197269d },
            { 173100.0d, 0.0000000193728d },
            { 173800.0d, 0.0000000190186d },
            { 174500.0d, 0.0000000186647d },
            { 175200.0d, 0.0000000183108d },
            { 175900.0d, 0.0000000179572d },
            { 176600.0d, 0.000000017604d },
            { 177300.0d, 0.0000000172514d },
            { 178000.0d, 0.0000000168994d },
            { 178700.0d, 0.000000016548d },
            { 179400.0d, 0.0000000161974d },
            { 180100.0d, 0.0000000158477d },
            { 180800.0d, 0.0000000154991d },
            { 181500.0d, 0.0000000151514d },
            { 182200.0d, 0.0000000148051d },
            { 182900.0d, 0.0000000144601d },
            { 183600.0d, 0.0000000141164d },
            { 184300.0d, 0.0000000137742d },
            { 185000.0d, 0.0000000134337d },
            { 185700.0d, 0.0000000130949d },
            { 186400.0d, 0.0000000127578d },
            { 187100.0d, 0.0000000124228d },
            { 187800.0d, 0.0000000120898d },
            { 188500.0d, 0.0000000117589d },
            { 189200.0d, 0.0000000114303d },
            { 189900.0d, 0.000000011104d },
            { 190600.0d, 0.0000000107802d },
            { 191300.0d, 0.000000010459d },
            { 192000.0d, 0.0000000101405d },
            { 192700.0d, 0.00000000982466d },
            { 193400.0d, 0.00000000951178d },
            { 194100.0d, 0.0000000092019d },
            { 194800.0d, 0.00000000889513d },
            { 195500.0d, 0.00000000859158d },
            { 196200.0d, 0.00000000829135d },
            { 196900.0d, 0.00000000799456d },
            { 197600.0d, 0.00000000770132d },
            { 198300.0d, 0.00000000741174d },
            { 199000.0d, 0.00000000712591d },
            { 199700.0d, 0.00000000684397d },
            { 200400.0d, 0.00000000656602d },
            { 201100.0d, 0.00000000629216d },
            { 201800.0d, 0.00000000602252d },
            { 202500.0d, 0.00000000575721d },
            { 203200.0d, 0.00000000549631d },
            { 203900.0d, 0.00000000523998d },
            { 204600.0d, 0.0000000049883d },
            { 205300.0d, 0.00000000474139d },
            { 206000.0d, 0.00000000449937d },
            { 206700.0d, 0.00000000426235d },
            { 207400.0d, 0.00000000403043d },
            { 208100.0d, 0.00000000380375d },
            { 208800.0d, 0.00000000358241d },
            { 209500.0d, 0.00000000336652d },
            { 210200.0d, 0.0000000031562d },
            { 210900.0d, 0.00000000295155d },
            { 211600.0d, 0.00000000275272d },
            { 212300.0d, 0.00000000255979d },
            { 213000.0d, 0.0000000023729d },
            { 213700.0d, 0.00000000219216d },
            { 214400.0d, 0.00000000201767d },
            { 215100.0d, 0.00000000184956d },
            { 215800.0d, 0.00000000168794d },
            { 216500.0d, 0.00000000153294d },
            { 217200.0d, 0.00000000138466d },
            { 217900.0d, 0.00000000124323d },
            { 218600.0d, 0.00000000110876d },
            { 219300.0d, 0.000000000981367d },
            { 220000.0d, 0.000000000861174d },
            { 220700.0d, 0.000000000748296d },
            { 221400.0d, 0.00000000064285d },
            { 222100.0d, 0.000000000544956d },
            { 222800.0d, 0.000000000454731d },
            { 223500.0d, 0.000000000372294d },
            { 224200.0d, 0.000000000297763d },
            { 224900.0d, 0.000000000231259d },
            { 225600.0d, 0.000000000172897d },
            { 226300.0d, 0.000000000122798d },
            { 227000.0d, 0.0000000000810798d },
            { 227700.0d, 0.0000000000478607d },
            { 228400.0d, 0.0000000000232587d },
            { 229100.0d, 0.00000000000739059d },
            { 229800.0d, 0.000000000000367388d },
            { 230000.0d, 0d },

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    