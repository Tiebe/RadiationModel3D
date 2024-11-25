using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Radium203m : RadioactiveSubstance
    {
        public override string name { get; } = "Radium203m";
        public override double halfLife { get; } = 0.024d;
        public override double atomicWeight { get; } = 203.0095d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Radon199() }, { 1.0d, new AlphaParticle(9005002.09) } } },

        };
    }
}
    