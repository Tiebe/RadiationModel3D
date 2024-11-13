
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Bohrium262m : RadioactiveSubstance
    {
        public override string name { get; } = "Bohrium262m";
        public override double halfLife { get; } = 0.0095d;
        public override double atomicWeight { get; } = 262.12289d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 1.0d, new List<RadioactiveSubstance> { new AlphaParticle(), new Dubnium258() } },

        };
    }
}
    
    