using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Germanium85 : RadioactiveSubstance
    {
        public override string name { get; } = "Germanium85";
        public override double halfLife { get; } = 0.503d;
        public override double atomicWeight { get; } = 84.94297d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Arsenic85() }, { 1.0d, new BetaParticle(-1, 5033000.0) }, { 0.0005d, new GammaParticle(101900.0, 0.01217) } } },
            { 0.165d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Arsenic85() }, { 1.0d, new BetaParticle(-1, 5033000.0) }, { 0.0005d, new GammaParticle(101900.0, 0.01217) } } },
            { 1.0d, new Dictionary<double, RadioactiveSubstance> {  } },

        };
    }
}
    