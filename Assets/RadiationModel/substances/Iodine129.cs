using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Iodine129 : RadioactiveSubstance
    {
        public override string name { get; } = "Iodine129";
        public override double halfLife { get; } = 495443737801094.4d;
        public override double atomicWeight { get; } = 128.90498d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Xenon129() }, { 1.0d, new BetaParticle(-1, 94535.0) }, { 0.0751d, new GammaParticle(39578.0, 0.03133) }, { 0.077738967438d, new GammaParticle(4540.0, 0.27309) }, { 0.194775584066491d, new GammaParticle(29458.0, 0.04209) }, { 0.3608291664810875d, new GammaParticle(29778.0, 0.04164) }, { 0.10460293321393328d, new GammaParticle(33726.0, 0.03676) }, { 0.12928922545242152d, new GammaParticle(34030.0, 0.03643) }, { 0.024686292238488252d, new GammaParticle(34414.0, 0.03603) } } },

        };
    }
}
    