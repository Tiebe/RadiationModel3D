using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Tellurium132p : RadioactiveSubstance
    {
        public override string name { get; } = "Tellurium132p";
        public override double halfLife { get; } = double.PositiveInfinity;
        public override double atomicWeight { get; } = 131.91147d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {
            { 1.0d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Tellurium132()), new(0.397d, new GammaParticle(103400.0, 0.01199)), new(0.997d, new GammaParticle(696900.0, 0.00178)), new(0.13d, new GammaParticle(775600.0, 0.0016)), new(0.02d, new GammaParticle(798000.0, 0.00155)), new(0.13d, new GammaParticle(926200.0, 0.00134)), new(0.998d, new GammaParticle(974000.0, 0.00127)), new(0.04622345508636d, new GammaParticle(4135.0, 0.29984)), new(0.10699656586258985d, new GammaParticle(27202.0, 0.04558)), new(0.19924872600109844d, new GammaParticle(27473.0, 0.04513)), new(0.0570215144916284d, new GammaParticle(31093.0, 0.03988)), new(0.06939518313631177d, new GammaParticle(31359.0, 0.03954)), new(0.012373668644683361d, new GammaParticle(31698.0, 0.03911)) } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    