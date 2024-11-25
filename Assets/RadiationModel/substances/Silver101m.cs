using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Silver101m : RadioactiveSubstance
    {
        public override string name { get; } = "Silver101m";
        public override double halfLife { get; } = 3.1d;
        public override double atomicWeight { get; } = 100.91298d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Silver101() }, { 0.61d, new GammaParticle(97700.0, 0.01269) }, { 0.473d, new GammaParticle(175500.0, 0.00706) }, { 0.044844504583999995d, new GammaParticle(3218.0, 0.38528) }, { 0.14564024326528963d, new GammaParticle(21990.0, 0.05638) }, { 0.27453391755945267d, new GammaParticle(22163.0, 0.05594) }, { 0.07605367050703385d, new GammaParticle(25030.0, 0.04953) }, { 0.08928700917525774d, new GammaParticle(25211.0, 0.04918) }, { 0.01323333866822389d, new GammaParticle(25454.0, 0.04871) } } },

        };
    }
}
    