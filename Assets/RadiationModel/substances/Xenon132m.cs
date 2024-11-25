using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Xenon132m : RadioactiveSubstance
    {
        public override string name { get; } = "Xenon132m";
        public override double halfLife { get; } = 0.00839d;
        public override double atomicWeight { get; } = 131.90711d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Xenon132() }, { 0.96d, new GammaParticle(173600.0, 0.00714) }, { 0.98d, new GammaParticle(538100.0, 0.0023) }, { 0.97d, new GammaParticle(600100.0, 0.00207) }, { 0.98d, new GammaParticle(667750.0, 0.00186) }, { 1.0d, new GammaParticle(772600.0, 0.0016) }, { 0.023848991039d, new GammaParticle(4540.0, 0.27309) }, { 0.0551207602078331d, new GammaParticle(29458.0, 0.04209) }, { 0.10211330160769379d, new GammaParticle(29778.0, 0.04164) }, { 0.029602238013327762d, new GammaParticle(33726.0, 0.03676) }, { 0.036588366184473115d, new GammaParticle(34030.0, 0.03643) }, { 0.006986128171145352d, new GammaParticle(34414.0, 0.03603) } } },

        };
    }
}
    