using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Thulium155m : RadioactiveSubstance
    {
        public override string name { get; } = "Thulium155m";
        public override double halfLife { get; } = 45.0d;
        public override double atomicWeight { get; } = 154.93925d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 0.98d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Holmium155() }, { 1.0d, new BetaParticle(1, betaPlusSpectrum) } } },
            { 0.02d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Holmium151() }, { 1.0d, new AlphaParticle(5635002.09) } } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    