using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Platinum175 : RadioactiveSubstance
    {
        public override string name { get; } = "Platinum175";
        public override double halfLife { get; } = 2.53d;
        public override double atomicWeight { get; } = 174.9724d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 0.64d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Osmium171() }, { 1.0d, new AlphaParticle(7185002.09) } } },
            { 0.36d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Osmium175() }, { 1.0d, new BetaParticle(1, betaPlusSpectrum) } } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    