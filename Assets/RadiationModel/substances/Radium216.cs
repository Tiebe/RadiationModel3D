using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Radium216 : RadioactiveSubstance
    {
        public override string name { get; } = "Radium216";
        public override double halfLife { get; } = double.PositiveInfinity;
        public override double atomicWeight { get; } = 216.00353d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new AlphaParticle(10547002.09), new Radon212() } },
            { 1e-10d, new List<RadioactiveSubstance> { new Francium216() } },

        };
    }
}
    
    