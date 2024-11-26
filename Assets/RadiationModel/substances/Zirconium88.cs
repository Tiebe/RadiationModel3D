using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Zirconium88 : RadioactiveSubstance
    {
        public override string name { get; } = "Zirconium88";
        public override double halfLife { get; } = 7205760.0d;
        public override double atomicWeight { get; } = 87.91022d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Yttrium88() }, { 0.973d, new GammaParticle(392870.0, 0.00316) }, { 0.0310419357825d, new GammaParticle(2027.0, 0.61166) }, { 0.18314457276427998d, new GammaParticle(14883.0, 0.08331) }, { 0.3511880589919079d, new GammaParticle(14958.0, 0.08289) }, { 0.08817897033726897d, new GammaParticle(16803.0, 0.07379) }, { 0.10034766824381208d, new GammaParticle(16880.0, 0.07345) }, { 0.012168697906543118d, new GammaParticle(17011.0, 0.07288) } } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    