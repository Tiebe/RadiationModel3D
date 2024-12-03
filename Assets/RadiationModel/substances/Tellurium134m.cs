using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Tellurium134m : RadioactiveSubstance
    {
        public override string name { get; } = "Tellurium134m";
        public override double halfLife { get; } = double.PositiveInfinity;
        public override double atomicWeight { get; } = 133.91321d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {
            { 1.0d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Tellurium134()), new(0.49d, new GammaParticle(115200.0, 0.01076)), new(0.96d, new GammaParticle(297000.0, 0.00417)), new(1.0d, new GammaParticle(1279010.0, 0.00097)), new(0.0418564282868d, new GammaParticle(4135.0, 0.29984)), new(0.1005759753622292d, new GammaParticle(27202.0, 0.04558)), new(0.18729231911029648d, new GammaParticle(27473.0, 0.04513)), new(0.053599799118713494d, new GammaParticle(31093.0, 0.03988)), new(0.06523095552747432d, new GammaParticle(31359.0, 0.03954)), new(0.011631156408760827d, new GammaParticle(31698.0, 0.03911)) } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    