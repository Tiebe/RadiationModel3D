using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Nihonium278 : RadioactiveSubstance
    {
        public override string name { get; } = "Nihonium278";
        public override double halfLife { get; } = 0.0014d;
        public override double atomicWeight { get; } = 278.17073d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Roentgenium274() }, { 1.0d, new AlphaParticle(13017002.09) } } },

        };
    }
}
    