using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Radium209 : RadioactiveSubstance
    {
        public override string name { get; } = "Radium209";
        public override double halfLife { get; } = 4.8d;
        public override double atomicWeight { get; } = 209.00199d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Radon205() }, { 1.0d, new AlphaParticle(8165002.09) } } },

        };
    }
}
    