using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Lutetium155m : RadioactiveSubstance
    {
        public override string name { get; } = "Lutetium155m";
        public override double halfLife { get; } = 0.138d;
        public override double atomicWeight { get; } = 154.95435d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 0.76d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Thulium151() }, { 1.0d, new AlphaParticle(6845002.09) } } },
            { 0.24d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Thulium155() }, { 1.0d, new BetaParticle(1, betaPlusSpectrum) } } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    