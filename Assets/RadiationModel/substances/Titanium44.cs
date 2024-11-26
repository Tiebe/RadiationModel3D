using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Titanium44 : RadioactiveSubstance
    {
        public override string name { get; } = "Titanium44";
        public override double halfLife { get; } = 1865014325.09839d;
        public override double atomicWeight { get; } = 43.95969d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Scandium44() }, { 0.93d, new GammaParticle(67867.9, 0.01827) }, { 0.968d, new GammaParticle(78323.4, 0.01583) }, { 0.00092d, new GammaParticle(146220.0, 0.00848) }, { 0.0045000000000000005d, new GammaParticle(422.0, 2.93801) }, { 0.0574d, new GammaParticle(4086.0, 0.30344) }, { 0.113d, new GammaParticle(4091.0, 0.30307) }, { 0.0225d, new GammaParticle(4474.0, 0.27712) }, { 0.0225d, new GammaParticle(4474.0, 0.27712) } } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    