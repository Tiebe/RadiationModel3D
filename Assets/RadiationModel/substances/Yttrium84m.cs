using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Yttrium84m : RadioactiveSubstance
    {
        public override string name { get; } = "Yttrium84m";
        public override double halfLife { get; } = 4.6d;
        public override double atomicWeight { get; } = 83.92074d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {
            { 1.0d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Rubidium84()), new(1.0d, new BetaParticle(1, betaPlusSpectrum)), new(0.3d, new GammaParticle(793000.0, 0.00156)), new(1.98d, new GammaParticle(511000.0, 0.00243)), new(0.00030679888744d, new GammaParticle(1890.0, 0.656)), new(0.0019347541580653754d, new GammaParticle(14098.0, 0.08794)), new(0.0037171069319219506d, new GammaParticle(14165.0, 0.08753)), new(0.0009178022212501544d, new GammaParticle(15898.0, 0.07799)), new(0.0010371165100126743d, new GammaParticle(15955.0, 0.07771)), new(0.00011931428876252007d, new GammaParticle(16085.0, 0.07708)) } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    