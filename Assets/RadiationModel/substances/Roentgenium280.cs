using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Roentgenium280 : RadioactiveSubstance
    {
        public override string name { get; } = "Roentgenium280";
        public override double halfLife { get; } = 4.4d;
        public override double atomicWeight { get; } = 280.16521d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Meitnerium276() }, { 1.0d, new AlphaParticle(11177002.09) } } },

        };
    }
}
    