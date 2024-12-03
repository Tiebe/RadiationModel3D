using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Rubidium82m : RadioactiveSubstance
    {
        public override string name { get; } = "Rubidium82m";
        public override double halfLife { get; } = 23299.2d;
        public override double atomicWeight { get; } = 81.91828d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {
            { 1.0d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Bromine82()), new(1.0d, new BetaParticle(1, betaPlusSpectrum)), new(0.00649803d, new GammaParticle(92190.0, 0.01345)), new(0.00109707d, new GammaParticle(100890.0, 0.01229)), new(0.00126585d, new GammaParticle(129290.0, 0.00959)), new(0.00118146d, new GammaParticle(137150.0, 0.00904)), new(0.021266280000000002d, new GammaParticle(183270.0, 0.00677)), new(0.02067555d, new GammaParticle(221460.0, 0.0056)), new(0.01037997d, new GammaParticle(273480.0, 0.00453)), new(0.0008439000000000001d, new GammaParticle(389400.0, 0.00318)), new(0.0050634d, new GammaParticle(401160.0, 0.00309)), new(0.0126585d, new GammaParticle(455280.0, 0.00272)), new(0.00210975d, new GammaParticle(499310.0, 0.00248)), new(0.624486d, new GammaParticle(554350.0, 0.00224)), new(0.01333362d, new GammaParticle(583800.0, 0.00212)), new(0.02008482d, new GammaParticle(606370.0, 0.00204)), new(0.37975499999999995d, new GammaParticle(619110.0, 0.002)), new(0.2632968d, new GammaParticle(698370.0, 0.00178)), new(0.00143463d, new GammaParticle(703560.0, 0.00176)), new(0.00312243d, new GammaParticle(735640.0, 0.00169)), new(0.00109707d, new GammaParticle(735640.0, 0.00169)), new(0.00312243d, new GammaParticle(755760.0, 0.00164)), new(0.8439d, new GammaParticle(776520.0, 0.0016)), new(0.21013110000000002d, new GammaParticle(827830.0, 0.0015)), new(0.0016878000000000002d, new GammaParticle(836000.0, 0.00148)), new(0.006413640000000001d, new GammaParticle(952020.0, 0.0013)), new(0.0009282899999999999d, new GammaParticle(963700.0, 0.00129)), new(0.00067512d, new GammaParticle(976900.0, 0.00127)), new(0.00033756d, new GammaParticle(987100.0, 0.00126)), new(0.0717315d, new GammaParticle(1007590.0, 0.00123)), new(0.32068199999999997d, new GammaParticle(1044080.0, 0.00119)), new(0.00725754d, new GammaParticle(1072990.0, 0.00116)), new(0.013080449999999999d, new GammaParticle(1081290.0, 0.00115)), new(0.00025317d, new GammaParticle(1086000.0, 0.00114)), new(0.00751071d, new GammaParticle(1099810.0, 0.00113)), new(0.00118146d, new GammaParticle(1180100.0, 0.00105)), new(0.00286926d, new GammaParticle(1190810.0, 0.00104)), new(0.00042195000000000004d, new GammaParticle(1218000.0, 0.00102)), new(0.00059073d, new GammaParticle(1228900.0, 0.00101)), new(0.2371359d, new GammaParticle(1317430.0, 0.00094)), new(0.0052321799999999995d, new GammaParticle(1330800.0, 0.00093)), new(0.0009282899999999999d, new GammaParticle(1374800.0, 0.0009)), new(0.00025317d, new GammaParticle(1395400.0, 0.00089)), new(0.0016034100000000002d, new GammaParticle(1441700.0, 0.00086)), new(0.15527760000000002d, new GammaParticle(1474880.0, 0.00084)), new(0.00016878d, new GammaParticle(1506800.0, 0.00082)), new(0.00042195000000000004d, new GammaParticle(1543000.0, 0.0008)), new(0.00033756d, new GammaParticle(1555300.0, 0.0008)), new(0.00025317d, new GammaParticle(1641300.0, 0.00076)), new(0.0118146d, new GammaParticle(1650370.0, 0.00075)), new(0.00033756d, new GammaParticle(1707800.0, 0.00073)), new(0.00025317d, new GammaParticle(1771000.0, 0.0007)), new(0.0026160899999999997d, new GammaParticle(1779660.0, 0.0007)), new(0.00118146d, new GammaParticle(1835200.0, 0.00068)), new(0.000270048d, new GammaParticle(1871500.0, 0.00066)), new(0.00059073d, new GammaParticle(1956600.0, 0.00063)), new(0.00016878d, new GammaParticle(1961300.0, 0.00063)), new(0.00109707d, new GammaParticle(1974000.0, 0.00063)), new(0.000472584d, new GammaParticle(1996500.0, 0.00062)), new(0.000270048d, new GammaParticle(2002000.0, 0.00062)), new(0.000236292d, new GammaParticle(2073000.0, 0.0006)), new(0.00019409699999999998d, new GammaParticle(2130800.0, 0.00058)), new(0.00101268d, new GammaParticle(2242950.0, 0.00055)), new(0.000784827d, new GammaParticle(2247470.0, 0.00055)), new(8.439e-05d, new GammaParticle(2305000.0, 0.00054)), new(0.00303804d, new GammaParticle(2315000.0, 0.00054)), new(0.43235999999999997d, new GammaParticle(511000.0, 0.00243)), new(0.0191d, new GammaParticle(1648.0, 0.75233)), new(0.133d, new GammaParticle(12596.0, 0.09843)), new(0.257d, new GammaParticle(12649.0, 0.09802)), new(0.0616d, new GammaParticle(14169.0, 0.0875)), new(0.0679d, new GammaParticle(14209.0, 0.08726)), new(0.0062d, new GammaParticle(14313.0, 0.08662)) } },
            { 0.0033d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Rubidium82()) } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    