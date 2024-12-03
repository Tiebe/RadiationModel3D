using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Tellurium131m : RadioactiveSubstance
    {
        public override string name { get; } = "Tellurium131m";
        public override double halfLife { get; } = 119700.0d;
        public override double atomicWeight { get; } = 130.90872d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {
            { 0.741d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Iodine131()), new(1.0d, new BetaParticle(-1, betaMinusSpectrum)), new(0.00011599999999999999d, new GammaParticle(36830.0, 0.03366)), new(6e-05d, new GammaParticle(51000.0, 0.02431)), new(5.2e-05d, new GammaParticle(52590.0, 0.02358)), new(1.1000000000000001e-05d, new GammaParticle(54100.0, 0.02292)), new(2.6e-05d, new GammaParticle(55800.0, 0.02222)), new(5.6e-05d, new GammaParticle(60840.0, 0.02038)), new(0.00035099999999999997d, new GammaParticle(62380.0, 0.01988)), new(4.1e-05d, new GammaParticle(63200.0, 0.01962)), new(7.8e-05d, new GammaParticle(65050.0, 0.01906)), new(0.00021999999999999998d, new GammaParticle(66950.0, 0.01852)), new(0.00026d, new GammaParticle(73320.0, 0.01691)), new(0.00015d, new GammaParticle(78570.0, 0.01578)), new(0.00123d, new GammaParticle(79190.0, 0.01566)), new(0.0392d, new GammaParticle(81140.0, 0.01528)), new(0.0014199999999999998d, new GammaParticle(86430.0, 0.01435)), new(3.7000000000000005e-05d, new GammaParticle(95000.0, 0.01305)), new(5.6e-05d, new GammaParticle(96400.0, 0.01286)), new(0.00013d, new GammaParticle(98300.0, 0.01261)), new(0.0007099999999999999d, new GammaParticle(100000.0, 0.0124)), new(0.00164d, new GammaParticle(101600.0, 0.0122)), new(0.0766d, new GammaParticle(102060.0, 0.01215)), new(0.00045d, new GammaParticle(103300.0, 0.012)), new(0.00026d, new GammaParticle(105000.0, 0.01181)), new(0.00034d, new GammaParticle(109400.0, 0.01133)), new(0.0003d, new GammaParticle(111900.0, 0.01108)), new(0.00010999999999999999d, new GammaParticle(113500.0, 0.01092)), new(3.7000000000000005e-05d, new GammaParticle(123700.0, 0.01002)), new(8e-05d, new GammaParticle(125200.0, 0.0099)), new(6e-05d, new GammaParticle(126100.0, 0.00983)), new(0.00021999999999999998d, new GammaParticle(127400.0, 0.00973)), new(0.00067d, new GammaParticle(130500.0, 0.0095)), new(4e-05d, new GammaParticle(132200.0, 0.00938)), new(0.0068000000000000005d, new GammaParticle(134860.0, 0.00919)), new(0.0007000000000000001d, new GammaParticle(137600.0, 0.00901)), new(0.00075d, new GammaParticle(149300.0, 0.0083)), new(0.049d, new GammaParticle(149710.0, 0.00828)), new(0.0007000000000000001d, new GammaParticle(151200.0, 0.0082)), new(0.00037d, new GammaParticle(155900.0, 0.00795)), new(0.00123d, new GammaParticle(159660.0, 0.00777)), new(0.0003d, new GammaParticle(169700.0, 0.00731)), new(0.00010999999999999999d, new GammaParticle(172000.0, 0.00721)), new(0.00063d, new GammaParticle(177200.0, 0.007)), new(0.0070999999999999995d, new GammaParticle(182250.0, 0.0068)), new(0.00149d, new GammaParticle(183110.0, 0.00677)), new(0.0020499999999999997d, new GammaParticle(188130.0, 0.00659)), new(0.0049d, new GammaParticle(189760.0, 0.00653)), new(0.0011200000000000001d, new GammaParticle(190520.0, 0.00651)), new(0.0728d, new GammaParticle(200630.0, 0.00618)), new(0.00018999999999999998d, new GammaParticle(203400.0, 0.0061)), new(0.00037d, new GammaParticle(207500.0, 0.00598)), new(0.00015d, new GammaParticle(210300.0, 0.0059)), new(0.00010999999999999999d, new GammaParticle(211900.0, 0.00585)), new(0.00411d, new GammaParticle(213980.0, 0.00579)), new(0.00015d, new GammaParticle(227700.0, 0.00545)), new(0.00187d, new GammaParticle(230650.0, 0.00538)), new(0.0009d, new GammaParticle(232300.0, 0.00534)), new(0.00015d, new GammaParticle(235000.0, 0.00528)), new(0.0732d, new GammaParticle(240930.0, 0.00515)), new(0.00627d, new GammaParticle(253170.0, 0.0049)), new(0.00299d, new GammaParticle(255440.0, 0.00485)), new(0.00015d, new GammaParticle(261400.0, 0.00474)), new(0.00015d, new GammaParticle(267200.0, 0.00464)), new(0.001046d, new GammaParticle(269200.0, 0.00461)), new(0.001046d, new GammaParticle(269200.0, 0.00461)), new(0.0172d, new GammaParticle(278560.0, 0.00445)), new(0.00034d, new GammaParticle(281400.0, 0.00441)), new(0.0037d, new GammaParticle(283200.0, 0.00438)), new(0.00075d, new GammaParticle(290300.0, 0.00427)), new(0.00049d, new GammaParticle(296800.0, 0.00418)), new(0.00037d, new GammaParticle(302700.0, 0.0041)), new(0.00037d, new GammaParticle(303900.0, 0.00408)), new(0.0036d, new GammaParticle(309470.0, 0.00401)), new(0.00015d, new GammaParticle(323700.0, 0.00383)), new(0.0003d, new GammaParticle(331200.0, 0.00374)), new(0.0922d, new GammaParticle(334270.0, 0.00371)), new(0.00131d, new GammaParticle(335440.0, 0.0037)), new(0.000747d, new GammaParticle(342920.0, 0.00362)), new(0.0037d, new GammaParticle(342920.0, 0.00362)), new(0.0009d, new GammaParticle(345900.0, 0.00358)), new(0.00202d, new GammaParticle(351300.0, 0.00353)), new(0.0007000000000000001d, new GammaParticle(353500.0, 0.00351)), new(0.0022d, new GammaParticle(354700.0, 0.0035)), new(0.00018999999999999998d, new GammaParticle(357400.0, 0.00347)), new(0.0007000000000000001d, new GammaParticle(362300.0, 0.00342)), new(0.0116d, new GammaParticle(364980.0, 0.0034)), new(0.00010999999999999999d, new GammaParticle(375800.0, 0.0033)), new(0.000373d, new GammaParticle(377800.0, 0.00328)), new(0.000373d, new GammaParticle(377800.0, 0.00328)), new(0.00018999999999999998d, new GammaParticle(379300.0, 0.00327)), new(0.0019d, new GammaParticle(383900.0, 0.00323)), new(0.0003d, new GammaParticle(403300.0, 0.00307)), new(0.0006d, new GammaParticle(408200.0, 0.00304)), new(0.00269d, new GammaParticle(417400.0, 0.00297)), new(0.0064d, new GammaParticle(432400.0, 0.00287)), new(0.015d, new GammaParticle(452300.0, 0.00274)), new(0.0176d, new GammaParticle(462920.0, 0.00268)), new(0.003d, new GammaParticle(468160.0, 0.00265)), new(0.0007000000000000001d, new GammaParticle(492650.0, 0.00252)), new(0.00086d, new GammaParticle(506800.0, 0.00245)), new(0.00131d, new GammaParticle(524800.0, 0.00236)), new(0.00101d, new GammaParticle(530700.0, 0.00234)), new(0.00108d, new GammaParticle(541400.0, 0.00229)), new(0.00037d, new GammaParticle(546700.0, 0.00227)), new(0.00021999999999999998d, new GammaParticle(558100.0, 0.00222)), new(0.00041d, new GammaParticle(572700.0, 0.00216)), new(0.00075d, new GammaParticle(579800.0, 0.00214)), new(0.019d, new GammaParticle(586300.0, 0.00211)), new(0.00049d, new GammaParticle(597000.0, 0.00208)), new(0.003d, new GammaParticle(602090.0, 0.00206)), new(0.00134d, new GammaParticle(609400.0, 0.00203)), new(0.000299d, new GammaParticle(637300.0, 0.00195)), new(0.0003d, new GammaParticle(657200.0, 0.00189)), new(0.0418d, new GammaParticle(665050.0, 0.00186)), new(0.0003d, new GammaParticle(681900.0, 0.00182)), new(0.00149d, new GammaParticle(685900.0, 0.00181)), new(0.0038d, new GammaParticle(695620.0, 0.00178)), new(0.00377d, new GammaParticle(702500.0, 0.00176)), new(0.0138d, new GammaParticle(713100.0, 0.00174)), new(0.00063d, new GammaParticle(738800.0, 0.00168)), new(0.015300000000000001d, new GammaParticle(744200.0, 0.00167)), new(0.00015d, new GammaParticle(749000.0, 0.00166)), new(0.368d, new GammaParticle(773670.0, 0.0016)), new(0.0052d, new GammaParticle(774100.0, 0.0016)), new(0.0751d, new GammaParticle(782490.0, 0.00158)), new(0.134d, new GammaParticle(793750.0, 0.00156)), new(0.00018999999999999998d, new GammaParticle(801600.0, 0.00155)), new(0.059000000000000004d, new GammaParticle(822780.0, 0.00151)), new(0.0015d, new GammaParticle(844900.0, 0.00147)), new(0.00037d, new GammaParticle(848900.0, 0.00146)), new(0.19899999999999998d, new GammaParticle(852210.0, 0.00145)), new(0.0037d, new GammaParticle(852210.0, 0.00145)), new(0.006d, new GammaParticle(856050.0, 0.00145)), new(0.0019d, new GammaParticle(865100.0, 0.00143)), new(0.00097d, new GammaParticle(872300.0, 0.00142)), new(0.00034d, new GammaParticle(881600.0, 0.00141)), new(0.0317d, new GammaParticle(910000.0, 0.00136)), new(0.0116d, new GammaParticle(920620.0, 0.00135)), new(0.0011200000000000001d, new GammaParticle(923400.0, 0.00134)), new(0.00018999999999999998d, new GammaParticle(930000.0, 0.00133)), new(0.0075d, new GammaParticle(941270.0, 0.00132)), new(0.00149d, new GammaParticle(987800.0, 0.00126)), new(0.00086d, new GammaParticle(995100.0, 0.00125)), new(0.00164d, new GammaParticle(999200.0, 0.00124)), new(0.00026d, new GammaParticle(1003600.0, 0.00124)), new(0.0007099999999999999d, new GammaParticle(1005700.0, 0.00123)), new(0.0006d, new GammaParticle(1023600.0, 0.00121)), new(7.000000000000001e-05d, new GammaParticle(1027800.0, 0.00121)), new(0.00101d, new GammaParticle(1035400.0, 0.0012)), new(0.0149d, new GammaParticle(1059690.0, 0.00117)), new(0.00021999999999999998d, new GammaParticle(1072300.0, 0.00116)), new(0.00021999999999999998d, new GammaParticle(1108300.0, 0.00112)), new(0.00010999999999999999d, new GammaParticle(1114100.0, 0.00111)), new(0.11d, new GammaParticle(1125460.0, 0.0011)), new(0.009300000000000001d, new GammaParticle(1127960.0, 0.0011)), new(7.000000000000001e-05d, new GammaParticle(1134200.0, 0.00109)), new(0.00486d, new GammaParticle(1148890.0, 0.00108)), new(0.015d, new GammaParticle(1148890.0, 0.00108)), new(0.0063d, new GammaParticle(1150900.0, 0.00108)), new(0.00026d, new GammaParticle(1162700.0, 0.00107)), new(0.00134d, new GammaParticle(1165500.0, 0.00106)), new(0.00010999999999999999d, new GammaParticle(1181400.0, 0.00105)), new(0.0941d, new GammaParticle(1206600.0, 0.00103)), new(0.0006d, new GammaParticle(1211000.0, 0.00102)), new(7.47e-05d, new GammaParticle(1227800.0, 0.00101)), new(7.47e-05d, new GammaParticle(1227800.0, 0.00101)), new(0.0063d, new GammaParticle(1237320.0, 0.001)), new(0.00026d, new GammaParticle(1254200.0, 0.00099)), new(0.0067d, new GammaParticle(1315160.0, 0.00094)), new(0.0009d, new GammaParticle(1316200.0, 0.00094)), new(0.00037d, new GammaParticle(1318300.0, 0.00094)), new(0.00052d, new GammaParticle(1333800.0, 0.00093)), new(0.00097d, new GammaParticle(1340600.0, 0.00092)), new(0.00041d, new GammaParticle(1376800.0, 0.0009)), new(0.00015d, new GammaParticle(1389600.0, 0.00089)), new(0.00105d, new GammaParticle(1394830.0, 0.00089)), new(0.00010999999999999999d, new GammaParticle(1403600.0, 0.00088)), new(0.0005600000000000001d, new GammaParticle(1496500.0, 0.00083)), new(0.00067d, new GammaParticle(1547750.0, 0.0008)), new(0.012d, new GammaParticle(1646010.0, 0.00075)), new(0.00015d, new GammaParticle(1696800.0, 0.00073)), new(7.000000000000001e-05d, new GammaParticle(1830600.0, 0.00068)), new(0.0006d, new GammaParticle(1880100.0, 0.00066)), new(0.0131d, new GammaParticle(1887700.0, 0.00066)), new(3.7000000000000005e-05d, new GammaParticle(1924100.0, 0.00064)), new(0.0007099999999999999d, new GammaParticle(1936150.0, 0.00064)), new(0.0003d, new GammaParticle(1980300.0, 0.00063)), new(0.0194d, new GammaParticle(2000940.0, 0.00062)), new(0.00336d, new GammaParticle(2168540.0, 0.00057)), new(0.0037d, new GammaParticle(2270650.0, 0.00055)), new(2.6e-05d, new GammaParticle(2332700.0, 0.00053)), new(0.010678090377552001d, new GammaParticle(4335.0, 0.28601)), new(0.02806253708488587d, new GammaParticle(28318.0, 0.04378)), new(0.0521220971116008d, new GammaParticle(28613.0, 0.04333)), new(0.015016632962082659d, new GammaParticle(32395.0, 0.03827)), new(0.01841039201151334d, new GammaParticle(32680.0, 0.03794)), new(0.0033937590494306806d, new GammaParticle(33040.0, 0.03753)) } },
            { 0.259d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Tellurium131()), new(0.00992d, new GammaParticle(182250.0, 0.0068)), new(0.0187566413314d, new GammaParticle(4135.0, 0.29984)), new(0.04189382090244007d, new GammaParticle(27202.0, 0.04558)), new(0.0780145640641342d, new GammaParticle(27473.0, 0.04513)), new(0.022326409230423772d, new GammaParticle(31093.0, 0.03988)), new(0.02717124003342573d, new GammaParticle(31359.0, 0.03954)), new(0.004844830803001958d, new GammaParticle(31698.0, 0.03911)) } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    