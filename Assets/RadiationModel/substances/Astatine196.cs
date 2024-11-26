using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Astatine196 : RadioactiveSubstance
    {
        public override string name { get; } = "Astatine196";
        public override double halfLife { get; } = 0.388d;
        public override double atomicWeight { get; } = 195.9958d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 0.951d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Bismuth192() }, { 1.0d, new AlphaParticle(8217002.09) } } },
            { 0.049d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Bismuth196() }, { 1.0d, new BetaParticle(1, betaPlusSpectrum) } } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    