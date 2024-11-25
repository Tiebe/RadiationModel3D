using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Radium215 : RadioactiveSubstance
    {
        public override string name { get; } = "Radium215";
        public override double halfLife { get; } = 0.00166d;
        public override double atomicWeight { get; } = 215.00272d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Radon211() }, { 1.0d, new AlphaParticle(9884002.09) } } },

        };
    }
}
    