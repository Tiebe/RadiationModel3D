using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Chlorine38m : RadioactiveSubstance
    {
        public override string name { get; } = "Chlorine38m";
        public override double halfLife { get; } = 0.715d;
        public override double atomicWeight { get; } = 37.96873d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {
            { 1.0d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Chlorine38()), new(0.9995d, new GammaParticle(671360.0, 0.00185)), new(1.1883145455e-06d, new GammaParticle(223.0, 5.55983)), new(1.681161413840141e-05d, new GammaParticle(2621.0, 0.47304)), new(3.325081910285089e-05d, new GammaParticle(2623.0, 0.47268)), new(4.3053692587476976e-06d, new GammaParticle(2816.0, 0.44028)), new(4.3053692587476976e-06d, new GammaParticle(2816.0, 0.44028)) } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    