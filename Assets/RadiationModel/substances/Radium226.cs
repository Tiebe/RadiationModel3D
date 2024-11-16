using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Radium226 : RadioactiveSubstance
    {
        public override string name { get; } = "Radium226";
        public override double halfLife { get; } = 50491123200.0d;
        public override double atomicWeight { get; } = 226.02541d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new AlphaParticle(5892602.09), new Radon222() } },
            { 2.6e-11d, new List<RadioactiveSubstance> { new Carbon14(), new Lead212() } },

        };
    }
}
    
    