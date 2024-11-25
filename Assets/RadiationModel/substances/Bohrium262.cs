using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Bohrium262 : RadioactiveSubstance
    {
        public override string name { get; } = "Bohrium262";
        public override double halfLife { get; } = 0.102d;
        public override double atomicWeight { get; } = 262.12265d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Dubnium258() }, { 1.0d, new AlphaParticle(11337002.09) } } },

        };
    }
}
    