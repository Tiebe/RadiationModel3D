
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Dubnium262 : RadioactiveSubstance
    {
        public override string name { get; } = "Dubnium262";
        public override double halfLife { get; } = 34.0d;
        public override double atomicWeight { get; } = 262.11406d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 0.52d, new List<RadioactiveSubstance> {  } },

            { 0.48d, new List<RadioactiveSubstance> { new AlphaParticle(), new Lawrencium258() } },

        };
    }
}
    
    