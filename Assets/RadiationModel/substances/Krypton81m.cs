using System.Collections.Generic;

namespace RadiationModel.substances
{
    public class Krypton81m : RadioactiveSubstance
    {
        public override string name { get; } = "Krypton81m";
        public override double halfLife { get; } = 13.1d;
        public override double atomicWeight { get; } = 80.91679d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {
            { 0.9999750000000001d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Krypton81()), new(0.676983d, new GammaParticle(190460.0, 0.00651)), new(0.0076340506439625d, new GammaParticle(1648.0, 0.75233)), new(0.05102946680865877d, new GammaParticle(12596.0, 0.09843)), new(0.09839850907955798d, new GammaParticle(12649.0, 0.09802)), new(0.023578887547041467d, new GammaParticle(14169.0, 0.0875)), new(0.02595563941178325d, new GammaParticle(14209.0, 0.08726)), new(0.0023767518647417798d, new GammaParticle(14313.0, 0.08662)) } },
            { 2.5e-05d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Bromine81()), new(5.48540238e-07d, new GammaParticle(1535.0, 0.80771)), new(4.009306793576123e-06d, new GammaParticle(11879.0, 0.10437)), new(7.738480589801434e-06d, new GammaParticle(11925.0, 0.10397)), new(1.8354554554608644e-06d, new GammaParticle(13345.0, 0.09291)), new(1.977152616622443e-06d, new GammaParticle(13377.0, 0.09268)), new(1.4169716116157874e-07d, new GammaParticle(13469.0, 0.09205)) } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    