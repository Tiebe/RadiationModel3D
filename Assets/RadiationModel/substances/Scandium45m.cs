using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Scandium45m : RadioactiveSubstance
    {
        public override string name { get; } = "Scandium45m";
        public override double halfLife { get; } = 0.3258d;
        public override double atomicWeight { get; } = 44.95592d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {
            { 1.0d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Scandium45()), new(0.0023599999999999997d, new GammaParticle(12400.0, 0.09999)), new(0.0039901716d, new GammaParticle(422.0, 2.93801)), new(0.04980259636839371d, new GammaParticle(4086.0, 0.30344)), new(0.09824935168355436d, new GammaParticle(4091.0, 0.30307)), new(0.019528051948051947d, new GammaParticle(4474.0, 0.27712)), new(0.019528051948051947d, new GammaParticle(4474.0, 0.27712)) } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    