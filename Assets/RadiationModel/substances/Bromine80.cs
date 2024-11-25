using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Bromine80 : RadioactiveSubstance
    {
        public override string name { get; } = "Bromine80";
        public override double halfLife { get; } = 1060.8d;
        public override double atomicWeight { get; } = 79.91853d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 0.917d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Krypton80() }, { 1.0d, new BetaParticle(-1, 1002250.0) }, { 0.067d, new GammaParticle(616300.0, 0.00201) }, { 0.0026d, new GammaParticle(639400.0, 0.00194) }, { 8e-05d, new GammaParticle(677000.0, 0.00183) }, { 0.00012d, new GammaParticle(687400.0, 0.0018) }, { 0.0019d, new GammaParticle(703800.0, 0.00176) }, { 0.00074d, new GammaParticle(1256200.0, 0.00099) }, { 1.5091117675e-07d, new GammaParticle(1648.0, 0.75233) }, { 1.0586507767739557e-06d, new GammaParticle(12596.0, 0.09843) }, { 2.0413628553296484e-06d, new GammaParticle(12649.0, 0.09802) }, { 4.89164578394255e-07d, new GammaParticle(14169.0, 0.0875) }, { 5.384723678963961e-07d, new GammaParticle(14209.0, 0.08726) }, { 4.9307789502140913e-08d, new GammaParticle(14313.0, 0.08662) } } },
            { 0.083d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Arsenic80() }, { 1.0d, new BetaParticle(1, -1837000.0) }, { 0.0108d, new GammaParticle(665800.0, 0.00186) }, { 8e-05d, new GammaParticle(677000.0, 0.00183) }, { 0.00012d, new GammaParticle(687400.0, 0.0018) }, { 0.000134d, new GammaParticle(788000.0, 0.00157) }, { 0.0004d, new GammaParticle(812200.0, 0.00153) }, { 0.044000000000000004d, new GammaParticle(511000.0, 0.00243) }, { 0.00123d, new GammaParticle(1426.0, 0.86945) }, { 0.009399999999999999d, new GammaParticle(11183.0, 0.11087) }, { 0.0183d, new GammaParticle(11223.0, 0.11047) }, { 0.0042699999999999995d, new GammaParticle(12546.0, 0.09882) }, { 0.00451d, new GammaParticle(12571.0, 0.09863) }, { 0.00024d, new GammaParticle(12652.0, 0.098) } } },

        };
    }
}
    