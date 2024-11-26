using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Neptunium230 : RadioactiveSubstance
    {
        public override string name { get; } = "Neptunium230";
        public override double halfLife { get; } = 276.0d;
        public override double atomicWeight { get; } = 230.03783d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {
            { 0.97d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Protactinium230()), new(1.0d, new BetaParticle(1, betaPlusSpectrum)) } },
            { 0.03d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Protactinium226()), new(1.0d, new AlphaParticle(7803002.09)) } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    