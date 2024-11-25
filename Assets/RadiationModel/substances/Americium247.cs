using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Americium247 : RadioactiveSubstance
    {
        public override string name { get; } = "Americium247";
        public override double halfLife { get; } = 1380.0d;
        public override double atomicWeight { get; } = 247.07209d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Curium247() }, { 1.0d, new BetaParticle(-1, 808500.0) }, { 0.00525d, new GammaParticle(58030.0, 0.02137) }, { 0.000825d, new GammaParticle(61670.0, 0.0201) }, { 0.0010249999999999999d, new GammaParticle(165700.0, 0.00748) }, { 0.0575d, new GammaParticle(226000.0, 0.00549) }, { 0.25d, new GammaParticle(285000.0, 0.00435) }, { 0.42883036448875006d, new GammaParticle(18579.0, 0.06673) }, { 0.10101113758089932d, new GammaParticle(104606.0, 0.01185) }, { 0.15815114698747348d, new GammaParticle(109286.0, 0.01134) }, { 0.05923161681333372d, new GammaParticle(123280.0, 0.01006) }, { 0.0800811459316272d, new GammaParticle(124855.0, 0.00993) }, { 0.02084952911829347d, new GammaParticle(126917.0, 0.00977) } } },

        };
    }
}
    