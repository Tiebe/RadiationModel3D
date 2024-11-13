
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Rhenium163 : RadioactiveSubstance
    {
        public override string name { get; } = "Rhenium163";
        public override double halfLife { get; } = 0.39d;
        public override double atomicWeight { get; } = 162.97209d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 0.32d, new List<RadioactiveSubstance> { new AlphaParticle(), new Tantalum159() } },

        };
    }
}
    
    