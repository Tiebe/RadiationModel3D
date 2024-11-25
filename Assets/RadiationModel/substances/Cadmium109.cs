using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Cadmium109 : RadioactiveSubstance
    {
        public override string name { get; } = "Cadmium109";
        public override double halfLife { get; } = 39908160.0d;
        public override double atomicWeight { get; } = 108.90499d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Silver109() }, { 0.03644d, new GammaParticle(88033.6, 0.01408) }, { 0.10355131732d, new GammaParticle(3218.0, 0.38528) }, { 0.29245877874288106d, new GammaParticle(21990.0, 0.05638) }, { 0.5512889325973253d, new GammaParticle(22163.0, 0.05594) }, { 0.15272264792145984d, new GammaParticle(25030.0, 0.04953) }, { 0.17929638865979386d, new GammaParticle(25211.0, 0.04918) }, { 0.02657374073833401d, new GammaParticle(25454.0, 0.04871) } } },

        };
    }
}
    