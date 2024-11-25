using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Silver107m : RadioactiveSubstance
    {
        public override string name { get; } = "Silver107m";
        public override double halfLife { get; } = 44.3d;
        public override double atomicWeight { get; } = 106.90519d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Silver107() }, { 0.0467d, new GammaParticle(93124.0, 0.01331) }, { 0.0487672814156d, new GammaParticle(3218.0, 0.38528) }, { 0.10417267195424985d, new GammaParticle(21990.0, 0.05638) }, { 0.19636695938595636d, new GammaParticle(22163.0, 0.05594) }, { 0.05439920925025028d, new GammaParticle(25030.0, 0.04953) }, { 0.06386467165979383d, new GammaParticle(25211.0, 0.04918) }, { 0.00946546240954355d, new GammaParticle(25454.0, 0.04871) } } },

        };
    }
}
    