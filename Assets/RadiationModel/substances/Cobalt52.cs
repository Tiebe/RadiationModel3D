using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Cobalt52 : RadioactiveSubstance
    {
        public override string name { get; } = "Cobalt52";
        public override double halfLife { get; } = 0.104d;
        public override double atomicWeight { get; } = 51.96313d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Manganese52() }, { 1.0d, new BetaParticle(1, 8183695.0) }, { 0.9998d, new GammaParticle(849430.0, 0.00146) }, { 0.629874d, new GammaParticle(1328950.0, 0.00093) }, { 0.689862d, new GammaParticle(1535270.0, 0.00081) }, { 0.459908d, new GammaParticle(1941700.0, 0.00064) } } },
            { 1.0d, new Dictionary<double, RadioactiveSubstance> {  } },

        };
    }
}
    