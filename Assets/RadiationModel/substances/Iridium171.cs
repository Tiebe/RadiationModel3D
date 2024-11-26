using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Iridium171 : RadioactiveSubstance
    {
        public override string name { get; } = "Iridium171";
        public override double halfLife { get; } = 3.2d;
        public override double atomicWeight { get; } = 170.97165d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 0.85d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Rhenium171() }, { 1.0d, new BetaParticle(1, betaPlusSpectrum) } } },
            { 0.15d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Rhenium167() }, { 1.0d, new AlphaParticle(7017002.09) } } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    