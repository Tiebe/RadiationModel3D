using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Silver103m : RadioactiveSubstance
    {
        public override string name { get; } = "Silver103m";
        public override double halfLife { get; } = 5.7d;
        public override double atomicWeight { get; } = 102.9091d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Silver103() }, { 0.214d, new GammaParticle(134440.0, 0.00922) }, { 0.03851899656d, new GammaParticle(3218.0, 0.38528) }, { 0.08642393282971335d, new GammaParticle(21990.0, 0.05638) }, { 0.16291033521152376d, new GammaParticle(22163.0, 0.05594) }, { 0.04513077679622052d, new GammaParticle(25030.0, 0.04953) }, { 0.05298353195876289d, new GammaParticle(25211.0, 0.04918) }, { 0.007852755162542371d, new GammaParticle(25454.0, 0.04871) } } },

        };
    }
}
    