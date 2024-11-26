using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Chromium51 : RadioactiveSubstance
    {
        public override string name { get; } = "Chromium51";
        public override double halfLife { get; } = 2393625.6d;
        public override double atomicWeight { get; } = 50.94477d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Vanadium51() }, { 0.09910000000000001d, new GammaParticle(320082.4, 0.00387) }, { 0.00558363156235386d, new GammaParticle(536.0, 2.31314) }, { 0.06789548877694662d, new GammaParticle(4945.0, 0.25073) }, { 0.13357365488283812d, new GammaParticle(4952.0, 0.25037) }, { 0.026875983764215284d, new GammaParticle(5444.0, 0.22774) }, { 0.026875983764215284d, new GammaParticle(5444.0, 0.22774) } } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    