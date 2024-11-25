using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Arsenic75m : RadioactiveSubstance
    {
        public override string name { get; } = "Arsenic75m";
        public override double halfLife { get; } = 0.01762d;
        public override double atomicWeight { get; } = 74.92192d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Arsenic75() }, { 0.00386d, new GammaParticle(24380.0, 0.05085) }, { 8.999999999999999e-05d, new GammaParticle(80940.0, 0.01532) }, { 0.00025d, new GammaParticle(198610.0, 0.00624) }, { 0.795d, new GammaParticle(279540.0, 0.00444) }, { 0.188d, new GammaParticle(303920.0, 0.00408) }, { 0.014670435175779999d, new GammaParticle(1320.0, 0.93927) }, { 0.11180918655546325d, new GammaParticle(10509.0, 0.11798) }, { 0.21697882118273484d, new GammaParticle(10544.0, 0.11759) }, { 0.049612836781462534d, new GammaParticle(11773.0, 0.10531) }, { 0.05148820201180183d, new GammaParticle(11791.0, 0.10515) }, { 0.001875365230339284d, new GammaParticle(11861.0, 0.10453) } } },

        };
    }
}
    