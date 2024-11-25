using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Indium114 : RadioactiveSubstance
    {
        public override string name { get; } = "Indium114";
        public override double halfLife { get; } = 71.9d;
        public override double atomicWeight { get; } = 113.90492d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 0.995d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Tin114() }, { 1.0d, new BetaParticle(-1, 994967.5) }, { 0.0014000000000000002d, new GammaParticle(1299830.0, 0.00095) }, { 7.00122584e-08d, new GammaParticle(3753.0, 0.33036) }, { 2.2018414339709121e-07d, new GammaParticle(25044.0, 0.04951) }, { 4.1209834062715924e-07d, new GammaParticle(25271.0, 0.04906) }, { 1.1652591142502058e-07d, new GammaParticle(28579.0, 0.04338) }, { 1.3948151597574963e-07d, new GammaParticle(28810.0, 0.04304) }, { 2.2955604550729053e-08d, new GammaParticle(29107.0, 0.0426) } } },
            { 0.005d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Silver114() }, { 1.0d, new BetaParticle(1, -1819400.0) }, { 0.000672d, new GammaParticle(558430.0, 0.00222) }, { 3.92e-05d, new GammaParticle(575800.0, 0.00215) }, { 1.8200000000000002e-06d, new GammaParticle(747800.0, 0.00166) }, { 6.8e-05d, new GammaParticle(511000.0, 0.00243) }, { 0.00029d, new GammaParticle(3388.0, 0.36595) }, { 0.001d, new GammaParticle(22983.0, 0.05395) }, { 0.0019d, new GammaParticle(23173.0, 0.0535) }, { 0.00054d, new GammaParticle(26184.0, 0.04735) }, { 0.00064d, new GammaParticle(26381.0, 0.047) }, { 0.0001d, new GammaParticle(26641.0, 0.04654) } } },

        };
    }
}
    