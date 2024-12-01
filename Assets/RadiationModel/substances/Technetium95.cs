using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Technetium95 : RadioactiveSubstance
    {
        public override string name { get; } = "Technetium95";
        public override double halfLife { get; } = 72000.0d;
        public override double atomicWeight { get; } = 94.90765d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {
            { 1.0d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Niobium95()), new(1.0d, new BetaParticle(1, betaPlusSpectrum)), new(0.00041280799999999997d, new GammaParticle(125800.0, 0.00986)), new(0.00010320199999999999d, new GammaParticle(126030.0, 0.00984)), new(2.5331400000000003e-05d, new GammaParticle(181880.0, 0.00682)), new(0.003039768d, new GammaParticle(204120.0, 0.00607)), new(0.000347134d, new GammaParticle(307930.0, 0.00403)), new(9.382000000000001e-07d, new GammaParticle(467100.0, 0.00265)), new(0.000131348d, new GammaParticle(477700.0, 0.0026)), new(1.4073e-05d, new GammaParticle(495160.0, 0.0025)), new(0.00014073000000000002d, new GammaParticle(561670.0, 0.00221)), new(0.000215786d, new GammaParticle(593160.0, 0.00209)), new(0.003039768d, new GammaParticle(604040.0, 0.00205)), new(0.9381999999999999d, new GammaParticle(765789.0, 0.00162)), new(0.000168876d, new GammaParticle(774990.0, 0.0016)), new(0.00145421d, new GammaParticle(785930.0, 0.00158)), new(0.003171116d, new GammaParticle(869600.0, 0.00143)), new(0.01951456d, new GammaParticle(947670.0, 0.00131)), new(1.5011200000000001e-05d, new GammaParticle(1056700.0, 0.00117)), new(0.037434180000000004d, new GammaParticle(1073710.0, 0.00115)), new(9.381999999999999e-05d, new GammaParticle(1221900.0, 0.00101)), new(6.567399999999999e-06d, new GammaParticle(1441000.0, 0.00086)), new(0.00020452760000000002d, new GammaParticle(1551710.0, 0.0008)), new(5.629199999999999e-06d, new GammaParticle(1645000.0, 0.00075)), new(9.381999999999999e-08d, new GammaParticle(1683000.0, 0.00074)), new(0.03818458457472318d, new GammaParticle(2440.0, 0.50813)), new(0.19135023598028933d, new GammaParticle(17374.0, 0.07136)), new(0.36468503140897535d, new GammaParticle(17479.0, 0.07093)), new(0.09569203128553548d, new GammaParticle(19681.0, 0.063)), new(0.11042860410350794d, new GammaParticle(19794.0, 0.06264)), new(0.014736572817972464d, new GammaParticle(19963.0, 0.06211)) } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    