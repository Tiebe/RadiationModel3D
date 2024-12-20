using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Silver115m : RadioactiveSubstance
    {
        public override string name { get; } = "Silver115m";
        public override double halfLife { get; } = 18.0d;
        public override double atomicWeight { get; } = 114.90881d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {
            { 0.79d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Cadmium115()), new(1.0d, new BetaParticle(-1, betaMinusSpectrum)) } },
            { 0.21d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Silver115()), new(0.000147d, new GammaParticle(41100.0, 0.03017)), new(0.002901493056d, new GammaParticle(3218.0, 0.38528)), new(0.0013968464129706282d, new GammaParticle(21990.0, 0.05638)), new(0.002633075236513908d, new GammaParticle(22163.0, 0.05594)), new(0.0007294364144084021d, new GammaParticle(25030.0, 0.04953)), new(0.000856358350515464d, new GammaParticle(25211.0, 0.04918)), new(0.00012692193610706198d, new GammaParticle(25454.0, 0.04871)) } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    