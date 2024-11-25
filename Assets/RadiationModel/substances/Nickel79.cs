using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Nickel79 : RadioactiveSubstance
    {
        public override string name { get; } = "Nickel79";
        public override double halfLife { get; } = 0.043d;
        public override double atomicWeight { get; } = 78.96977d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Copper79() }, { 1.0d, new BetaParticle(-1, 7125000.0) } } },
            { 1.0d, new Dictionary<double, RadioactiveSubstance> {  } },
            { 1.0d, new Dictionary<double, RadioactiveSubstance> {  } },

        };
    }
}
    