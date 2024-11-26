using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Francium200m : RadioactiveSubstance
    {
        public override string name { get; } = "Francium200m";
        public override double halfLife { get; } = 0.0496d;
        public override double atomicWeight { get; } = 200.00663d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {
            { 0.975d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Astatine196()), new(1.0d, new AlphaParticle(8687002.09)) } },
            { 0.025d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Astatine200()), new(1.0d, new BetaParticle(1, betaPlusSpectrum)) } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    