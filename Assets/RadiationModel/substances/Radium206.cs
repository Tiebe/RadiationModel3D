
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Radium206 : RadioactiveSubstance
    {
        public override string name { get; } = "Radium206";
        public override double halfLife { get; } = 0.24d;
        public override double atomicWeight { get; } = 206.00383d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 1.0d, new List<RadioactiveSubstance> { new AlphaParticle(), new Radon202() } },

        };
    }
}
    
    