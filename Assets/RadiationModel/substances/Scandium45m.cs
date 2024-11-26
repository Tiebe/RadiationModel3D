using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Scandium45m : RadioactiveSubstance
    {
        public override string name { get; } = "Scandium45m";
        public override double halfLife { get; } = 0.3258d;
        public override double atomicWeight { get; } = 44.95592d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Scandium45() }, { 0.0023599999999999997d, new GammaParticle(12400.0, 0.09999) }, { 0.0039901716d, new GammaParticle(422.0, 2.93801) }, { 0.04980259636839371d, new GammaParticle(4086.0, 0.30344) }, { 0.09824935168355436d, new GammaParticle(4091.0, 0.30307) }, { 0.019528051948051947d, new GammaParticle(4474.0, 0.27712) }, { 0.019528051948051947d, new GammaParticle(4474.0, 0.27712) } } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    