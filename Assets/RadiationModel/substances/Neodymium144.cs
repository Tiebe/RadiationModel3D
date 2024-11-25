using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Neodymium144 : RadioactiveSubstance
    {
        public override string name { get; } = "Neodymium144";
        public override double halfLife { get; } = 7.226536048181568e+22d;
        public override double atomicWeight { get; } = 143.91009d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Cerium140() }, { 1.0d, new AlphaParticle(2923202.0900000003) } } },

        };
    }
}
    