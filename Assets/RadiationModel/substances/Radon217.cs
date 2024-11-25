using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Radon217 : RadioactiveSubstance
    {
        public override string name { get; } = "Radon217";
        public override double halfLife { get; } = 0.00054d;
        public override double atomicWeight { get; } = 217.00393d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Polonium213() }, { 1.0d, new AlphaParticle(8910002.09) } } },

        };
    }
}
    