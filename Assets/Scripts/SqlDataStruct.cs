using UnityEngine;
using System.Collections.Generic;
using System;

namespace Redatoms
{
    public class SqlDataBase
    {
        public virtual SqlDataBase InitWithAttributes(Dictionary<string, System.Object> data)
        {
            return null;
        }
    }

    public class ActorLevel : SqlDataBase
    {
        // id
        public int id;
        // 等级
        public int lv;
        // 体力上限
        public int ep;
        // 裸体战斗力
        public int atk;
        // 裸体血量
        public int hp;
        // 裸体防御
        public int def;

        public static ActorLevel Copy(ActorLevel other)
        {
            ActorLevel ret = new ActorLevel();
            ret.id = other.id;
            ret.lv = other.lv;
            ret.ep = other.ep;
            ret.atk = other.atk;
            ret.hp = other.hp;
            ret.def = other.def;

            return ret;
        }

        public override SqlDataBase InitWithAttributes(Dictionary<string, System.Object> data)
        {
            this.id = Convert.ToInt32(data["id"]);
            this.lv = Convert.ToInt32(data["lv"]);
            this.ep = Convert.ToInt32(data["ep"]);
            this.atk = Convert.ToInt32(data["atk"]);
            this.hp = Convert.ToInt32(data["hp"]);
            this.def = Convert.ToInt32(data["def"]);

            return this;
        }
    }

    public class ActorUpgrade : SqlDataBase
    {
        // 等级
        public int id;
        // 角色经验
        public int exp;
        // 升级奖励体力
        public int ep;

        public static ActorUpgrade Copy(ActorUpgrade other)
        {
            ActorUpgrade ret = new ActorUpgrade();
            ret.id = other.id;
            ret.exp = other.exp;
            ret.ep = other.ep;

            return ret;
        }

        public override SqlDataBase InitWithAttributes(Dictionary<string, System.Object> data)
        {
            this.id = Convert.ToInt32(data["id"]);
            this.exp = Convert.ToInt32(data["exp"]);
            this.ep = Convert.ToInt32(data["ep"]);

            return this;
        }
    }

    public class LansquenetInfo : SqlDataBase
    {
        // 序号
        public int id;
        // 佣兵名称
        public string name;
        // 是否上架
        public int status;
        // 佣兵类型
        public int lans_type;
        // 枪械类型
        public int weapon_type;
        // 星级下限
        public int star_mix;
        // 星级上限
        public int star_max;
        // 基础战力
        public int atk;
        // 战力参数
        public float atk_factor;
        // 裸体血量
        public int hp;
        // 血量成长
        public int hp_growth;
        // 裸体防御
        public int def;
        // 防御成长
        public int def_growth;
        // 裸体暴击
        public float crit;
        // 暴击成长
        public float crit_growth;
        // 换弹加速
        public float reload_speed;
        // 换弹成长
        public float reload_speed_growth;
        // 命中率
        public float hit_ratio;
        // 命中成长
        public float hit_ratio_growth;
        // 受伤躲闪
        public int dodge;
        // 受伤成长
        public int dodge_growth;
        // 攻击间隔
        public float atk_interval;
        // 间隔成长
        public float atk_interval_growth;
        // 移动速度
        public float move_speed;
        // 移动成长
        public float move_speed_growth;
        // 默认枪械ID
        public int main_weapon;
        // 技能名称
        public string skill_name;
        // 技能描述
        public string skill_desc;
        // 锁定目标时间
        public float aim_time;
        // 锁定目标成长
        public float aim_time_growth;
        // 停止开火HP%
        public float stop_fire;
        // 停止开火成长
        public float stop_fire_growth;
        // 最小子弹数
        public int bullet_min;
        // 子弹成长
        public int bullet_growth;
        // 下蹲受到最大伤害
        public int hurt_max;
        // 下蹲成长
        public int hurt_max_growth;

        public static LansquenetInfo Copy(LansquenetInfo other)
        {
            LansquenetInfo ret = new LansquenetInfo();
            ret.id = other.id;
            ret.name = other.name;
            ret.status = other.status;
            ret.lans_type = other.lans_type;
            ret.weapon_type = other.weapon_type;
            ret.star_mix = other.star_mix;
            ret.star_max = other.star_max;
            ret.atk = other.atk;
            ret.atk_factor = other.atk_factor;
            ret.hp = other.hp;
            ret.hp_growth = other.hp_growth;
            ret.def = other.def;
            ret.def_growth = other.def_growth;
            ret.crit = other.crit;
            ret.crit_growth = other.crit_growth;
            ret.reload_speed = other.reload_speed;
            ret.reload_speed_growth = other.reload_speed_growth;
            ret.hit_ratio = other.hit_ratio;
            ret.hit_ratio_growth = other.hit_ratio_growth;
            ret.dodge = other.dodge;
            ret.dodge_growth = other.dodge_growth;
            ret.atk_interval = other.atk_interval;
            ret.atk_interval_growth = other.atk_interval_growth;
            ret.move_speed = other.move_speed;
            ret.move_speed_growth = other.move_speed_growth;
            ret.main_weapon = other.main_weapon;
            ret.skill_name = other.skill_name;
            ret.skill_desc = other.skill_desc;
            ret.aim_time = other.aim_time;
            ret.aim_time_growth = other.aim_time_growth;
            ret.stop_fire = other.stop_fire;
            ret.stop_fire_growth = other.stop_fire_growth;
            ret.bullet_min = other.bullet_min;
            ret.bullet_growth = other.bullet_growth;
            ret.hurt_max = other.hurt_max;
            ret.hurt_max_growth = other.hurt_max_growth;

            return ret;
        }

        public override SqlDataBase InitWithAttributes(Dictionary<string, System.Object> data)
        {
            this.id = Convert.ToInt32(data["id"]);
            this.name = Convert.ToString(data["name"]);
            this.status = Convert.ToInt32(data["status"]);
            this.lans_type = Convert.ToInt32(data["lans_type"]);
            this.weapon_type = Convert.ToInt32(data["weapon_type"]);
            this.star_mix = Convert.ToInt32(data["star_mix"]);
            this.star_max = Convert.ToInt32(data["star_max"]);
            this.atk = Convert.ToInt32(data["atk"]);
            this.atk_factor = Convert.ToSingle(data["atk_factor"]);
            this.hp = Convert.ToInt32(data["hp"]);
            this.hp_growth = Convert.ToInt32(data["hp_growth"]);
            this.def = Convert.ToInt32(data["def"]);
            this.def_growth = Convert.ToInt32(data["def_growth"]);
            this.crit = Convert.ToSingle(data["crit"]);
            this.crit_growth = Convert.ToSingle(data["crit_growth"]);
            this.reload_speed = Convert.ToSingle(data["reload_speed"]);
            this.reload_speed_growth = Convert.ToSingle(data["reload_speed_growth"]);
            this.hit_ratio = Convert.ToSingle(data["hit_ratio"]);
            this.hit_ratio_growth = Convert.ToSingle(data["hit_ratio_growth"]);
            this.dodge = Convert.ToInt32(data["dodge"]);
            this.dodge_growth = Convert.ToInt32(data["dodge_growth"]);
            this.atk_interval = Convert.ToSingle(data["atk_interval"]);
            this.atk_interval_growth = Convert.ToSingle(data["atk_interval_growth"]);
            this.move_speed = Convert.ToSingle(data["move_speed"]);
            this.move_speed_growth = Convert.ToSingle(data["move_speed_growth"]);
            this.main_weapon = Convert.ToInt32(data["main_weapon"]);
            this.skill_name = Convert.ToString(data["skill_name"]);
            this.skill_desc = Convert.ToString(data["skill_desc"]);
            this.aim_time = Convert.ToSingle(data["aim_time"]);
            this.aim_time_growth = Convert.ToSingle(data["aim_time_growth"]);
            this.stop_fire = Convert.ToSingle(data["stop_fire"]);
            this.stop_fire_growth = Convert.ToSingle(data["stop_fire_growth"]);
            this.bullet_min = Convert.ToInt32(data["bullet_min"]);
            this.bullet_growth = Convert.ToInt32(data["bullet_growth"]);
            this.hurt_max = Convert.ToInt32(data["hurt_max"]);
            this.hurt_max_growth = Convert.ToInt32(data["hurt_max_growth"]);

            return this;
        }
    }

    public class LansquenetUpgrade : SqlDataBase
    {
        // 等级
        public int id;
        // 佣兵经验
        public int exp;
        // 佣兵当前等级总需要经验
        public int total_exp;
        // 升级消耗金币
        public int cost_gold;
        // 佣兵当前等级总花费金钱
        public int total_gold;
        // 炼化金币
        public int gold;
        // 炼化钻石
        public int diamond;

        public static LansquenetUpgrade Copy(LansquenetUpgrade other)
        {
            LansquenetUpgrade ret = new LansquenetUpgrade();
            ret.id = other.id;
            ret.exp = other.exp;
            ret.total_exp = other.total_exp;
            ret.cost_gold = other.cost_gold;
            ret.total_gold = other.total_gold;
            ret.gold = other.gold;
            ret.diamond = other.diamond;

            return ret;
        }

        public override SqlDataBase InitWithAttributes(Dictionary<string, System.Object> data)
        {
            this.id = Convert.ToInt32(data["id"]);
            this.exp = Convert.ToInt32(data["exp"]);
            this.total_exp = Convert.ToInt32(data["total_exp"]);
            this.cost_gold = Convert.ToInt32(data["cost_gold"]);
            this.total_gold = Convert.ToInt32(data["total_gold"]);
            this.gold = Convert.ToInt32(data["gold"]);
            this.diamond = Convert.ToInt32(data["diamond"]);

            return this;
        }
    }

    public class LansquenetStarLv : SqlDataBase
    {
        // id
        public int id;
        // 星级
        public int star_lv;
        // 佣兵ID
        public int lan_id;
        // 血量
        public int hp;
        // 防御
        public int def;
        // 暴击
        public float crit;
        // 换弹加速
        public float reload_speed;
        // 命中率
        public float hit_ratio;
        // 受伤躲闪
        public int hurt_avoid;
        // 攻击间隔
        public float atk_interval;
        // 移动速度
        public float move_speed;
        // 佣兵成长系数
        public float growth_factor;

        public static LansquenetStarLv Copy(LansquenetStarLv other)
        {
            LansquenetStarLv ret = new LansquenetStarLv();
            ret.id = other.id;
            ret.star_lv = other.star_lv;
            ret.lan_id = other.lan_id;
            ret.hp = other.hp;
            ret.def = other.def;
            ret.crit = other.crit;
            ret.reload_speed = other.reload_speed;
            ret.hit_ratio = other.hit_ratio;
            ret.hurt_avoid = other.hurt_avoid;
            ret.atk_interval = other.atk_interval;
            ret.move_speed = other.move_speed;
            ret.growth_factor = other.growth_factor;

            return ret;
        }

        public override SqlDataBase InitWithAttributes(Dictionary<string, System.Object> data)
        {
            this.id = Convert.ToInt32(data["id"]);
            this.star_lv = Convert.ToInt32(data["star_lv"]);
            this.lan_id = Convert.ToInt32(data["lan_id"]);
            this.hp = Convert.ToInt32(data["hp"]);
            this.def = Convert.ToInt32(data["def"]);
            this.crit = Convert.ToSingle(data["crit"]);
            this.reload_speed = Convert.ToSingle(data["reload_speed"]);
            this.hit_ratio = Convert.ToSingle(data["hit_ratio"]);
            this.hurt_avoid = Convert.ToInt32(data["hurt_avoid"]);
            this.atk_interval = Convert.ToSingle(data["atk_interval"]);
            this.move_speed = Convert.ToSingle(data["move_speed"]);
            this.growth_factor = Convert.ToSingle(data["growth_factor"]);

            return this;
        }
    }

    public class LansquenetStarUpgrade : SqlDataBase
    {
        // 星级
        public int id;
        // 佣兵最低等级
        public int need_lv_min;
        // 佣兵最高等级
        public int need_lv_max;
        // 需求同名材料星级
        public int need_mat_star;
        // 需求个数
        public int need_mat_num;
        // 进阶消耗金币
        public int cost_gold;
        // 进阶消耗钻石
        public int cost_diamond;
        // 佣兵颜色
        public int star_color;

        public static LansquenetStarUpgrade Copy(LansquenetStarUpgrade other)
        {
            LansquenetStarUpgrade ret = new LansquenetStarUpgrade();
            ret.id = other.id;
            ret.need_lv_min = other.need_lv_min;
            ret.need_lv_max = other.need_lv_max;
            ret.need_mat_star = other.need_mat_star;
            ret.need_mat_num = other.need_mat_num;
            ret.cost_gold = other.cost_gold;
            ret.cost_diamond = other.cost_diamond;
            ret.star_color = other.star_color;

            return ret;
        }

        public override SqlDataBase InitWithAttributes(Dictionary<string, System.Object> data)
        {
            this.id = Convert.ToInt32(data["id"]);
            this.need_lv_min = Convert.ToInt32(data["need_lv_min"]);
            this.need_lv_max = Convert.ToInt32(data["need_lv_max"]);
            this.need_mat_star = Convert.ToInt32(data["need_mat_star"]);
            this.need_mat_num = Convert.ToInt32(data["need_mat_num"]);
            this.cost_gold = Convert.ToInt32(data["cost_gold"]);
            this.cost_diamond = Convert.ToInt32(data["cost_diamond"]);
            this.star_color = Convert.ToInt32(data["star_color"]);

            return this;
        }
    }

    public class LansquenetUnlock : SqlDataBase
    {
        // 佣兵格
        public int id;
        // 消耗钻石
        public int cost_diamond;
        // 角色等级需求
        public int unlock_lv;
        // VIP等级需求
        public int unlock_vip;

        public static LansquenetUnlock Copy(LansquenetUnlock other)
        {
            LansquenetUnlock ret = new LansquenetUnlock();
            ret.id = other.id;
            ret.cost_diamond = other.cost_diamond;
            ret.unlock_lv = other.unlock_lv;
            ret.unlock_vip = other.unlock_vip;

            return ret;
        }

        public override SqlDataBase InitWithAttributes(Dictionary<string, System.Object> data)
        {
            this.id = Convert.ToInt32(data["id"]);
            this.cost_diamond = Convert.ToInt32(data["cost_diamond"]);
            this.unlock_lv = Convert.ToInt32(data["unlock_lv"]);
            this.unlock_vip = Convert.ToInt32(data["unlock_vip"]);

            return this;
        }
    }

    public class WeaponInfo : SqlDataBase
    {
        // 枪械ID
        public int id;
        // 枪械类型
        public int type;
        // 枪械类型名称
        public string type_desc;
        // Prefab名称
        public string prefab_name;
        // 枪械名称
        public string name;
        // 枪械描述
        public string desc;
        // 是否上架
        public int status;
        // 枪械星级下限
        public int star_min;
        // 枪械星级上限
        public int star_max;
        // 基础火力
        public int fire;
        // 火力系数
        public float fire_ratio;
        // 枪械评价
        public string appraise;
        // 单发子弹数
        public int buts_per_fire;
        // 基础伤害
        public float hurt;
        // 伤害成长
        public float hurt_growth;
        // 部件伤害成长
        public float part_hurt_growth;
        // 基础暴击
        public float crit;
        // 暴击成长
        public float crit_growth;
        // 上弹时间
        public float reload_time;
        // 上弹成长
        public float reload_growth;
        // 基础精准
        public float accurate;
        // 精准成长
        public float accurate_growth;
        // 基础弹夹
        public float clip;
        // 弹夹成长
        public float clip_growth;
        // 基础射速
        public float fire_speed;
        // 射速成长
        public float fire_speed_growth;
        // 基础射程
        public float fire_range;
        // 射程成长
        public float fire_range_growth;
        // 基础穿透
        public float penetrate;
        // 穿透成长
        public float penetrate_growth;
        // 基础后坐力
        public float recoil;
        // 后坐力成长
        public float recoil_growth;

        public static WeaponInfo Copy(WeaponInfo other)
        {
            WeaponInfo ret = new WeaponInfo();
            ret.id = other.id;
            ret.type = other.type;
            ret.type_desc = other.type_desc;
            ret.prefab_name = other.prefab_name;
            ret.name = other.name;
            ret.desc = other.desc;
            ret.status = other.status;
            ret.star_min = other.star_min;
            ret.star_max = other.star_max;
            ret.fire = other.fire;
            ret.fire_ratio = other.fire_ratio;
            ret.appraise = other.appraise;
            ret.buts_per_fire = other.buts_per_fire;
            ret.hurt = other.hurt;
            ret.hurt_growth = other.hurt_growth;
            ret.part_hurt_growth = other.part_hurt_growth;
            ret.crit = other.crit;
            ret.crit_growth = other.crit_growth;
            ret.reload_time = other.reload_time;
            ret.reload_growth = other.reload_growth;
            ret.accurate = other.accurate;
            ret.accurate_growth = other.accurate_growth;
            ret.clip = other.clip;
            ret.clip_growth = other.clip_growth;
            ret.fire_speed = other.fire_speed;
            ret.fire_speed_growth = other.fire_speed_growth;
            ret.fire_range = other.fire_range;
            ret.fire_range_growth = other.fire_range_growth;
            ret.penetrate = other.penetrate;
            ret.penetrate_growth = other.penetrate_growth;
            ret.recoil = other.recoil;
            ret.recoil_growth = other.recoil_growth;

            return ret;
        }

        public override SqlDataBase InitWithAttributes(Dictionary<string, System.Object> data)
        {
            this.id = Convert.ToInt32(data["id"]);
            this.type = Convert.ToInt32(data["type"]);
            this.type_desc = Convert.ToString(data["type_desc"]);
            this.prefab_name = Convert.ToString(data["prefab_name"]);
            this.name = Convert.ToString(data["name"]);
            this.desc = Convert.ToString(data["desc"]);
            this.status = Convert.ToInt32(data["status"]);
            this.star_min = Convert.ToInt32(data["star_min"]);
            this.star_max = Convert.ToInt32(data["star_max"]);
            this.fire = Convert.ToInt32(data["fire"]);
            this.fire_ratio = Convert.ToSingle(data["fire_ratio"]);
            this.appraise = Convert.ToString(data["appraise"]);
            this.buts_per_fire = Convert.ToInt32(data["buts_per_fire"]);
            this.hurt = Convert.ToSingle(data["hurt"]);
            this.hurt_growth = Convert.ToSingle(data["hurt_growth"]);
            this.part_hurt_growth = Convert.ToSingle(data["part_hurt_growth"]);
            this.crit = Convert.ToSingle(data["crit"]);
            this.crit_growth = Convert.ToSingle(data["crit_growth"]);
            this.reload_time = Convert.ToSingle(data["reload_time"]);
            this.reload_growth = Convert.ToSingle(data["reload_growth"]);
            this.accurate = Convert.ToSingle(data["accurate"]);
            this.accurate_growth = Convert.ToSingle(data["accurate_growth"]);
            this.clip = Convert.ToSingle(data["clip"]);
            this.clip_growth = Convert.ToSingle(data["clip_growth"]);
            this.fire_speed = Convert.ToSingle(data["fire_speed"]);
            this.fire_speed_growth = Convert.ToSingle(data["fire_speed_growth"]);
            this.fire_range = Convert.ToSingle(data["fire_range"]);
            this.fire_range_growth = Convert.ToSingle(data["fire_range_growth"]);
            this.penetrate = Convert.ToSingle(data["penetrate"]);
            this.penetrate_growth = Convert.ToSingle(data["penetrate_growth"]);
            this.recoil = Convert.ToSingle(data["recoil"]);
            this.recoil_growth = Convert.ToSingle(data["recoil_growth"]);

            return this;
        }
    }

    public class WeaponBulletInfo : SqlDataBase
    {
        // 枪械ID
        public int id;
        // 准星精准度除数
        public int accu_divisor;
        // 准星偏移
        public float accu_offset;
        // 准星最大精准度
        public float accu_max;
        // 后座力上扬基础值
        public float up_base;
        // 后座力上扬增益
        public float up_modifier;
        // 后座力上扬最大值
        public float up_max;
        // 后座力侧移基础
        public float lateral_base;
        // 后座力侧移增益
        public float lateral_modifier;
        // 后座力侧移最大
        public float lateral_max;
        // 准星回复延迟1
        public float cross_delay;
        // 
        public float camera_shake_factor;
        // 
        public float fpunch_damping;
        // 
        public float fpunch_spring_constant;
        // 
        public int dir_change;
        // 
        public int up_dirchange;
        // 
        public float crosshair_shrink_speed;
        // 
        public int ignore_gunshake;
        // 范围穿透因子
        public float range_atten_factor;
        // 最大伤害距离
        public int max_hurt_range;
        // 最小伤害距离
        public int min_hurt_range;
        // 头部伤害因子
        public float head_scale;
        // 头部暴击伤害因子
        public float head_scale_crit;
        // 胸部伤害因子
        public float chest_scale;
        // 胸部暴击伤害因子
        public float chest_scale_crit;
        // 油桶伤害因子
        public float chrunk_scale;
        // 油桶暴击伤害
        public float chunk_scale_crit;
        // 四肢伤害因子
        public float limb_scale;
        // 四肢暴击伤害因子
        public float limb_scale_crit;
        // Bunker伤害因子
        public float widget_scale;
        // Bunker暴击伤害因子
        public float widget_scale_crit;
        // 
        public float fCrosshairResetTime;

        public static WeaponBulletInfo Copy(WeaponBulletInfo other)
        {
            WeaponBulletInfo ret = new WeaponBulletInfo();
            ret.id = other.id;
            ret.accu_divisor = other.accu_divisor;
            ret.accu_offset = other.accu_offset;
            ret.accu_max = other.accu_max;
            ret.up_base = other.up_base;
            ret.up_modifier = other.up_modifier;
            ret.up_max = other.up_max;
            ret.lateral_base = other.lateral_base;
            ret.lateral_modifier = other.lateral_modifier;
            ret.lateral_max = other.lateral_max;
            ret.cross_delay = other.cross_delay;
            ret.camera_shake_factor = other.camera_shake_factor;
            ret.fpunch_damping = other.fpunch_damping;
            ret.fpunch_spring_constant = other.fpunch_spring_constant;
            ret.dir_change = other.dir_change;
            ret.up_dirchange = other.up_dirchange;
            ret.crosshair_shrink_speed = other.crosshair_shrink_speed;
            ret.ignore_gunshake = other.ignore_gunshake;
            ret.range_atten_factor = other.range_atten_factor;
            ret.max_hurt_range = other.max_hurt_range;
            ret.min_hurt_range = other.min_hurt_range;
            ret.head_scale = other.head_scale;
            ret.head_scale_crit = other.head_scale_crit;
            ret.chest_scale = other.chest_scale;
            ret.chest_scale_crit = other.chest_scale_crit;
            ret.chrunk_scale = other.chrunk_scale;
            ret.chunk_scale_crit = other.chunk_scale_crit;
            ret.limb_scale = other.limb_scale;
            ret.limb_scale_crit = other.limb_scale_crit;
            ret.widget_scale = other.widget_scale;
            ret.widget_scale_crit = other.widget_scale_crit;
            ret.fCrosshairResetTime = other.fCrosshairResetTime;

            return ret;
        }

        public override SqlDataBase InitWithAttributes(Dictionary<string, System.Object> data)
        {
            this.id = Convert.ToInt32(data["id"]);
            this.accu_divisor = Convert.ToInt32(data["accu_divisor"]);
            this.accu_offset = Convert.ToSingle(data["accu_offset"]);
            this.accu_max = Convert.ToSingle(data["accu_max"]);
            this.up_base = Convert.ToSingle(data["up_base"]);
            this.up_modifier = Convert.ToSingle(data["up_modifier"]);
            this.up_max = Convert.ToSingle(data["up_max"]);
            this.lateral_base = Convert.ToSingle(data["lateral_base"]);
            this.lateral_modifier = Convert.ToSingle(data["lateral_modifier"]);
            this.lateral_max = Convert.ToSingle(data["lateral_max"]);
            this.cross_delay = Convert.ToSingle(data["cross_delay"]);
            this.camera_shake_factor = Convert.ToSingle(data["camera_shake_factor"]);
            this.fpunch_damping = Convert.ToSingle(data["fpunch_damping"]);
            this.fpunch_spring_constant = Convert.ToSingle(data["fpunch_spring_constant"]);
            this.dir_change = Convert.ToInt32(data["dir_change"]);
            this.up_dirchange = Convert.ToInt32(data["up_dirchange"]);
            this.crosshair_shrink_speed = Convert.ToSingle(data["crosshair_shrink_speed"]);
            this.ignore_gunshake = Convert.ToInt32(data["ignore_gunshake"]);
            this.range_atten_factor = Convert.ToSingle(data["range_atten_factor"]);
            this.max_hurt_range = Convert.ToInt32(data["max_hurt_range"]);
            this.min_hurt_range = Convert.ToInt32(data["min_hurt_range"]);
            this.head_scale = Convert.ToSingle(data["head_scale"]);
            this.head_scale_crit = Convert.ToSingle(data["head_scale_crit"]);
            this.chest_scale = Convert.ToSingle(data["chest_scale"]);
            this.chest_scale_crit = Convert.ToSingle(data["chest_scale_crit"]);
            this.chrunk_scale = Convert.ToSingle(data["chrunk_scale"]);
            this.chunk_scale_crit = Convert.ToSingle(data["chunk_scale_crit"]);
            this.limb_scale = Convert.ToSingle(data["limb_scale"]);
            this.limb_scale_crit = Convert.ToSingle(data["limb_scale_crit"]);
            this.widget_scale = Convert.ToSingle(data["widget_scale"]);
            this.widget_scale_crit = Convert.ToSingle(data["widget_scale_crit"]);
            this.fCrosshairResetTime = Convert.ToSingle(data["fCrosshairResetTime"]);

            return this;
        }
    }

    public class WeaponStar : SqlDataBase
    {
        // 星级
        public int id;
        // 枪械最高等级
        public int weapon_lv_max;
        // 等级增加枪械火力
        public int lv_add_fire;
        // 配件增加枪械火力
        public int part_add_fire;
        // 枪械火力参数
        public float fire_factor;
        // 枪械伤害参数
        public float hurt_factor;
        // 枪械配件参数
        public float part_factor;
        // 枪械经验值
        public int exp;

        public static WeaponStar Copy(WeaponStar other)
        {
            WeaponStar ret = new WeaponStar();
            ret.id = other.id;
            ret.weapon_lv_max = other.weapon_lv_max;
            ret.lv_add_fire = other.lv_add_fire;
            ret.part_add_fire = other.part_add_fire;
            ret.fire_factor = other.fire_factor;
            ret.hurt_factor = other.hurt_factor;
            ret.part_factor = other.part_factor;
            ret.exp = other.exp;

            return ret;
        }

        public override SqlDataBase InitWithAttributes(Dictionary<string, System.Object> data)
        {
            this.id = Convert.ToInt32(data["id"]);
            this.weapon_lv_max = Convert.ToInt32(data["weapon_lv_max"]);
            this.lv_add_fire = Convert.ToInt32(data["lv_add_fire"]);
            this.part_add_fire = Convert.ToInt32(data["part_add_fire"]);
            this.fire_factor = Convert.ToSingle(data["fire_factor"]);
            this.hurt_factor = Convert.ToSingle(data["hurt_factor"]);
            this.part_factor = Convert.ToSingle(data["part_factor"]);
            this.exp = Convert.ToInt32(data["exp"]);

            return this;
        }
    }

    public class EquipmentLevel : SqlDataBase
    {
        // id
        public int id;
        // 佩戴者类型(1.Player 2.MerceNary)
        public int user_type;
        // 装备类型(1头盔；2防弹衣；3作战服；4军靴；5手套)
        public int type;
        // 等级
        public int lv;
        // 血量
        public int hp;
        // 防御
        public int def;
        // 暴击(%)
        public float crit;
        // 换弹加速
        public float reload_speed;
        // 移动速度
        public float move_speed;
        // 道具冷却
        public float prop_cold;
        // 道具强度
        public int prop_strength;
        // 攻击间隔
        public float atk_interval;
        // 受伤躲闪
        public int hurt_avoid;
        // 命中率
        public float hit_ratio;

        public static EquipmentLevel Copy(EquipmentLevel other)
        {
            EquipmentLevel ret = new EquipmentLevel();
            ret.id = other.id;
            ret.user_type = other.user_type;
            ret.type = other.type;
            ret.lv = other.lv;
            ret.hp = other.hp;
            ret.def = other.def;
            ret.crit = other.crit;
            ret.reload_speed = other.reload_speed;
            ret.move_speed = other.move_speed;
            ret.prop_cold = other.prop_cold;
            ret.prop_strength = other.prop_strength;
            ret.atk_interval = other.atk_interval;
            ret.hurt_avoid = other.hurt_avoid;
            ret.hit_ratio = other.hit_ratio;

            return ret;
        }

        public override SqlDataBase InitWithAttributes(Dictionary<string, System.Object> data)
        {
            this.id = Convert.ToInt32(data["id"]);
            this.user_type = Convert.ToInt32(data["user_type"]);
            this.type = Convert.ToInt32(data["type"]);
            this.lv = Convert.ToInt32(data["lv"]);
            this.hp = Convert.ToInt32(data["hp"]);
            this.def = Convert.ToInt32(data["def"]);
            this.crit = Convert.ToSingle(data["crit"]);
            this.reload_speed = Convert.ToSingle(data["reload_speed"]);
            this.move_speed = Convert.ToSingle(data["move_speed"]);
            this.prop_cold = Convert.ToSingle(data["prop_cold"]);
            this.prop_strength = Convert.ToInt32(data["prop_strength"]);
            this.atk_interval = Convert.ToSingle(data["atk_interval"]);
            this.hurt_avoid = Convert.ToInt32(data["hurt_avoid"]);
            this.hit_ratio = Convert.ToSingle(data["hit_ratio"]);

            return this;
        }
    }

    public class EquipmentUpgrade : SqlDataBase
    {
        // id
        public int id;
        // 佩戴者类型(1.Player 2.MerceNary)
        public int user_type;
        // 装备类型(1头盔2防弹衣3作战服4军靴5手套)
        public int type;
        // 等级
        public int lv;
        // 升级消耗金钱
        public int cost_gold;
        // 升级消耗钻石
        public int cost_diamond;
        // 材料ID
        public int mat_id_w;
        // 个数
        public int need_w;
        // 材料ID
        public int mat_id_g;
        // 个数
        public int need_g;
        // 材料ID
        public int mat_id_b;
        // 个数
        public int need_b;
        // 材料ID
        public int mat_id_p;
        // 个数
        public int need_p;
        // 材料id
        public int mat_id_o;
        // 个数
        public int need_o;

        public static EquipmentUpgrade Copy(EquipmentUpgrade other)
        {
            EquipmentUpgrade ret = new EquipmentUpgrade();
            ret.id = other.id;
            ret.user_type = other.user_type;
            ret.type = other.type;
            ret.lv = other.lv;
            ret.cost_gold = other.cost_gold;
            ret.cost_diamond = other.cost_diamond;
            ret.mat_id_w = other.mat_id_w;
            ret.need_w = other.need_w;
            ret.mat_id_g = other.mat_id_g;
            ret.need_g = other.need_g;
            ret.mat_id_b = other.mat_id_b;
            ret.need_b = other.need_b;
            ret.mat_id_p = other.mat_id_p;
            ret.need_p = other.need_p;
            ret.mat_id_o = other.mat_id_o;
            ret.need_o = other.need_o;

            return ret;
        }

        public override SqlDataBase InitWithAttributes(Dictionary<string, System.Object> data)
        {
            this.id = Convert.ToInt32(data["id"]);
            this.user_type = Convert.ToInt32(data["user_type"]);
            this.type = Convert.ToInt32(data["type"]);
            this.lv = Convert.ToInt32(data["lv"]);
            this.cost_gold = Convert.ToInt32(data["cost_gold"]);
            this.cost_diamond = Convert.ToInt32(data["cost_diamond"]);
            this.mat_id_w = Convert.ToInt32(data["mat_id_w"]);
            this.need_w = Convert.ToInt32(data["need_w"]);
            this.mat_id_g = Convert.ToInt32(data["mat_id_g"]);
            this.need_g = Convert.ToInt32(data["need_g"]);
            this.mat_id_b = Convert.ToInt32(data["mat_id_b"]);
            this.need_b = Convert.ToInt32(data["need_b"]);
            this.mat_id_p = Convert.ToInt32(data["mat_id_p"]);
            this.need_p = Convert.ToInt32(data["need_p"]);
            this.mat_id_o = Convert.ToInt32(data["mat_id_o"]);
            this.need_o = Convert.ToInt32(data["need_o"]);

            return this;
        }
    }

    public class WeaponUpgrade : SqlDataBase
    {
        // id
        public int id;
        // 枪械等级
        public int level;
        // 升级经验
        public int exp;
        // iAccumulationExp
        public int acc_exp;
        // 升级消耗金钱
        public int gold;
        // iAccumulationMoney
        public int acc_gold;

        public static WeaponUpgrade Copy(WeaponUpgrade other)
        {
            WeaponUpgrade ret = new WeaponUpgrade();
            ret.id = other.id;
            ret.level = other.level;
            ret.exp = other.exp;
            ret.acc_exp = other.acc_exp;
            ret.gold = other.gold;
            ret.acc_gold = other.acc_gold;

            return ret;
        }

        public override SqlDataBase InitWithAttributes(Dictionary<string, System.Object> data)
        {
            this.id = Convert.ToInt32(data["id"]);
            this.level = Convert.ToInt32(data["level"]);
            this.exp = Convert.ToInt32(data["exp"]);
            this.acc_exp = Convert.ToInt32(data["acc_exp"]);
            this.gold = Convert.ToInt32(data["gold"]);
            this.acc_gold = Convert.ToInt32(data["acc_gold"]);

            return this;
        }
    }

    public class WeaponStarUpgrade : SqlDataBase
    {
        // 星级
        public int id;
        // 需求同名材料星级
        public int need_mat_star;
        // 需求个数
        public int need_mat_num;
        // 枪械颜色
        public int star_color;

        public static WeaponStarUpgrade Copy(WeaponStarUpgrade other)
        {
            WeaponStarUpgrade ret = new WeaponStarUpgrade();
            ret.id = other.id;
            ret.need_mat_star = other.need_mat_star;
            ret.need_mat_num = other.need_mat_num;
            ret.star_color = other.star_color;

            return ret;
        }

        public override SqlDataBase InitWithAttributes(Dictionary<string, System.Object> data)
        {
            this.id = Convert.ToInt32(data["id"]);
            this.need_mat_star = Convert.ToInt32(data["need_mat_star"]);
            this.need_mat_num = Convert.ToInt32(data["need_mat_num"]);
            this.star_color = Convert.ToInt32(data["star_color"]);

            return this;
        }
    }

    public class WeaponWidgetUpgrade : SqlDataBase
    {
        // id
        public int id;
        // 枪械类型
        public int type;
        // 配件部位
        public int wtype;
        // 等级
        public int lv;
        // 升级消耗金钱
        public int cost_gold;
        // 升级消耗钻石
        public int cost_diamond;
        // 材料ID
        public int mat_id_w;
        // 个数
        public int need_w;
        // 材料ID
        public int mat_id_g;
        // 个数
        public int need_g;
        // 材料ID
        public int mat_id_b;
        // 个数
        public int need_b;
        // 材料ID
        public int mat_id_p;
        // 个数
        public int need_p;
        // 材料id
        public int mat_id_o;
        // 个数
        public int need_o;

        public static WeaponWidgetUpgrade Copy(WeaponWidgetUpgrade other)
        {
            WeaponWidgetUpgrade ret = new WeaponWidgetUpgrade();
            ret.id = other.id;
            ret.type = other.type;
            ret.wtype = other.wtype;
            ret.lv = other.lv;
            ret.cost_gold = other.cost_gold;
            ret.cost_diamond = other.cost_diamond;
            ret.mat_id_w = other.mat_id_w;
            ret.need_w = other.need_w;
            ret.mat_id_g = other.mat_id_g;
            ret.need_g = other.need_g;
            ret.mat_id_b = other.mat_id_b;
            ret.need_b = other.need_b;
            ret.mat_id_p = other.mat_id_p;
            ret.need_p = other.need_p;
            ret.mat_id_o = other.mat_id_o;
            ret.need_o = other.need_o;

            return ret;
        }

        public override SqlDataBase InitWithAttributes(Dictionary<string, System.Object> data)
        {
            this.id = Convert.ToInt32(data["id"]);
            this.type = Convert.ToInt32(data["type"]);
            this.wtype = Convert.ToInt32(data["wtype"]);
            this.lv = Convert.ToInt32(data["lv"]);
            this.cost_gold = Convert.ToInt32(data["cost_gold"]);
            this.cost_diamond = Convert.ToInt32(data["cost_diamond"]);
            this.mat_id_w = Convert.ToInt32(data["mat_id_w"]);
            this.need_w = Convert.ToInt32(data["need_w"]);
            this.mat_id_g = Convert.ToInt32(data["mat_id_g"]);
            this.need_g = Convert.ToInt32(data["need_g"]);
            this.mat_id_b = Convert.ToInt32(data["mat_id_b"]);
            this.need_b = Convert.ToInt32(data["need_b"]);
            this.mat_id_p = Convert.ToInt32(data["mat_id_p"]);
            this.need_p = Convert.ToInt32(data["need_p"]);
            this.mat_id_o = Convert.ToInt32(data["mat_id_o"]);
            this.need_o = Convert.ToInt32(data["need_o"]);

            return this;
        }
    }

    public class Chapter : SqlDataBase
    {
        // ID
        public int id;
        // 名称
        public string name;
        // 未开启提示
        public string lock_tip;

        public static Chapter Copy(Chapter other)
        {
            Chapter ret = new Chapter();
            ret.id = other.id;
            ret.name = other.name;
            ret.lock_tip = other.lock_tip;

            return ret;
        }

        public override SqlDataBase InitWithAttributes(Dictionary<string, System.Object> data)
        {
            this.id = Convert.ToInt32(data["id"]);
            this.name = Convert.ToString(data["name"]);
            this.lock_tip = Convert.ToString(data["lock_tip"]);

            return this;
        }
    }

    public class Stage : SqlDataBase
    {
        // ID
        public int id;
        // 章ID
        public int chapter_id;
        // 节序号
        public int no;
        // 精英关卡
        public int is_elite;
        // 关卡类型(是否战车)
        public int type;
        // 关卡名称
        public string name;
        // 关卡介绍
        public string desc;
        // 关卡icon
        public string icon;
        // 进场模式
        public int mode_enter;
        // 离场模式
        public int mode_leave;

        public static Stage Copy(Stage other)
        {
            Stage ret = new Stage();
            ret.id = other.id;
            ret.chapter_id = other.chapter_id;
            ret.no = other.no;
            ret.is_elite = other.is_elite;
            ret.type = other.type;
            ret.name = other.name;
            ret.desc = other.desc;
            ret.icon = other.icon;
            ret.mode_enter = other.mode_enter;
            ret.mode_leave = other.mode_leave;

            return ret;
        }

        public override SqlDataBase InitWithAttributes(Dictionary<string, System.Object> data)
        {
            this.id = Convert.ToInt32(data["id"]);
            this.chapter_id = Convert.ToInt32(data["chapter_id"]);
            this.no = Convert.ToInt32(data["no"]);
            this.is_elite = Convert.ToInt32(data["is_elite"]);
            this.type = Convert.ToInt32(data["type"]);
            this.name = Convert.ToString(data["name"]);
            this.desc = Convert.ToString(data["desc"]);
            this.icon = Convert.ToString(data["icon"]);
            this.mode_enter = Convert.ToInt32(data["mode_enter"]);
            this.mode_leave = Convert.ToInt32(data["mode_leave"]);

            return this;
        }
    }

    public class StageLevel : SqlDataBase
    {
        // ID
        public int id;
        // 关卡ID（旧版保留）
        public int level_id;
        // chapter_id
        public int chapter_id;
        // stage_no
        public int stage_no;
        // 精英关卡
        public int is_elite;
        // 难度
        public int level;
        // 章节ID(iLevelID)
        public int series_id;
        // scene
        public string scene_name;
        // 前置关卡
        public int req_stage_level_id;
        // 等级限制
        public int req_lv;
        // 总星级限制
        public int req_star;
        // 难度模式
        public int mode_lv;
        // 掩体等级
        public int lv_bunker;
        // 消耗体力
        public int ep;
        // 推荐战力
        public int power;
        // 推荐火力
        public int fire;
        // 进场模式
        public int mode_enter;
        // 离场模式
        public int mode_leave;
        // 基础金币奖励
        public int gold_base;
        // 连杀奖励金币基础
        public int gold_base_mk;
        // 连杀金币
        public int gold_mk;
        // 爆头金币
        public int gold_hs;
        // 金币上限
        public int gold_max;
        // 关卡积分
        public int score_base;
        // 敌人积分基础
        public int score_base_mk;
        // 敌人连杀积分
        public int score_mk;
        // 敌人爆头积分
        public int score_hs;
        // 时间积分系数
        public int score_time;
        // 最小时间
        public int time_min;
        // 最大时间
        public int time_max;
        // 日常次数
        public int times;
        // 重置价格
        public int reset_diamond;
        // 消耗扫荡券
        public int tickets;
        // 展示奖励1
        public int award1;
        // 展示奖励2
        public int award2;
        // 展示奖励3
        public int award3;
        // 展示奖励4
        public int award4;
        // pkg1
        public int pkg1;
        // pkg2
        public int pkg2;
        // pkg3
        public int pkg3;
        // pkg4
        public int pkg4;
        // pkg5
        public int pkg5;
        // pkg6
        public int pkg6;

        public static StageLevel Copy(StageLevel other)
        {
            StageLevel ret = new StageLevel();
            ret.id = other.id;
            ret.level_id = other.level_id;
            ret.chapter_id = other.chapter_id;
            ret.stage_no = other.stage_no;
            ret.is_elite = other.is_elite;
            ret.level = other.level;
            ret.series_id = other.series_id;
            ret.scene_name = other.scene_name;
            ret.req_stage_level_id = other.req_stage_level_id;
            ret.req_lv = other.req_lv;
            ret.req_star = other.req_star;
            ret.mode_lv = other.mode_lv;
            ret.lv_bunker = other.lv_bunker;
            ret.ep = other.ep;
            ret.power = other.power;
            ret.fire = other.fire;
            ret.mode_enter = other.mode_enter;
            ret.mode_leave = other.mode_leave;
            ret.gold_base = other.gold_base;
            ret.gold_base_mk = other.gold_base_mk;
            ret.gold_mk = other.gold_mk;
            ret.gold_hs = other.gold_hs;
            ret.gold_max = other.gold_max;
            ret.score_base = other.score_base;
            ret.score_base_mk = other.score_base_mk;
            ret.score_mk = other.score_mk;
            ret.score_hs = other.score_hs;
            ret.score_time = other.score_time;
            ret.time_min = other.time_min;
            ret.time_max = other.time_max;
            ret.times = other.times;
            ret.reset_diamond = other.reset_diamond;
            ret.tickets = other.tickets;
            ret.award1 = other.award1;
            ret.award2 = other.award2;
            ret.award3 = other.award3;
            ret.award4 = other.award4;
            ret.pkg1 = other.pkg1;
            ret.pkg2 = other.pkg2;
            ret.pkg3 = other.pkg3;
            ret.pkg4 = other.pkg4;
            ret.pkg5 = other.pkg5;
            ret.pkg6 = other.pkg6;

            return ret;
        }

        public override SqlDataBase InitWithAttributes(Dictionary<string, System.Object> data)
        {
            this.id = Convert.ToInt32(data["id"]);
            this.level_id = Convert.ToInt32(data["level_id"]);
            this.chapter_id = Convert.ToInt32(data["chapter_id"]);
            this.stage_no = Convert.ToInt32(data["stage_no"]);
            this.is_elite = Convert.ToInt32(data["is_elite"]);
            this.level = Convert.ToInt32(data["level"]);
            this.series_id = Convert.ToInt32(data["series_id"]);
            this.scene_name = Convert.ToString(data["scene_name"]);
            this.req_stage_level_id = Convert.ToInt32(data["req_stage_level_id"]);
            this.req_lv = Convert.ToInt32(data["req_lv"]);
            this.req_star = Convert.ToInt32(data["req_star"]);
            this.mode_lv = Convert.ToInt32(data["mode_lv"]);
            this.lv_bunker = Convert.ToInt32(data["lv_bunker"]);
            this.ep = Convert.ToInt32(data["ep"]);
            this.power = Convert.ToInt32(data["power"]);
            this.fire = Convert.ToInt32(data["fire"]);
            this.mode_enter = Convert.ToInt32(data["mode_enter"]);
            this.mode_leave = Convert.ToInt32(data["mode_leave"]);
            this.gold_base = Convert.ToInt32(data["gold_base"]);
            this.gold_base_mk = Convert.ToInt32(data["gold_base_mk"]);
            this.gold_mk = Convert.ToInt32(data["gold_mk"]);
            this.gold_hs = Convert.ToInt32(data["gold_hs"]);
            this.gold_max = Convert.ToInt32(data["gold_max"]);
            this.score_base = Convert.ToInt32(data["score_base"]);
            this.score_base_mk = Convert.ToInt32(data["score_base_mk"]);
            this.score_mk = Convert.ToInt32(data["score_mk"]);
            this.score_hs = Convert.ToInt32(data["score_hs"]);
            this.score_time = Convert.ToInt32(data["score_time"]);
            this.time_min = Convert.ToInt32(data["time_min"]);
            this.time_max = Convert.ToInt32(data["time_max"]);
            this.times = Convert.ToInt32(data["times"]);
            this.reset_diamond = Convert.ToInt32(data["reset_diamond"]);
            this.tickets = Convert.ToInt32(data["tickets"]);
            this.award1 = Convert.ToInt32(data["award1"]);
            this.award2 = Convert.ToInt32(data["award2"]);
            this.award3 = Convert.ToInt32(data["award3"]);
            this.award4 = Convert.ToInt32(data["award4"]);
            this.pkg1 = Convert.ToInt32(data["pkg1"]);
            this.pkg2 = Convert.ToInt32(data["pkg2"]);
            this.pkg3 = Convert.ToInt32(data["pkg3"]);
            this.pkg4 = Convert.ToInt32(data["pkg4"]);
            this.pkg5 = Convert.ToInt32(data["pkg5"]);
            this.pkg6 = Convert.ToInt32(data["pkg6"]);

            return this;
        }
    }

    public class LevelResult : SqlDataBase
    {
        // ID
        public int id;
        // 关卡ID
        public int level_id;
        // 描述
        public string desc;
        // 条件类型
        public int type;
        // 参数1
        public int param1;
        // 参数2
        public int param2;
        // 奖励积分
        public int score;
        // 奖励经验
        public int exp;
        // 奖励金钱
        public int gold;
        // 完成条件
        public int ctype;

        public static LevelResult Copy(LevelResult other)
        {
            LevelResult ret = new LevelResult();
            ret.id = other.id;
            ret.level_id = other.level_id;
            ret.desc = other.desc;
            ret.type = other.type;
            ret.param1 = other.param1;
            ret.param2 = other.param2;
            ret.score = other.score;
            ret.exp = other.exp;
            ret.gold = other.gold;
            ret.ctype = other.ctype;

            return ret;
        }

        public override SqlDataBase InitWithAttributes(Dictionary<string, System.Object> data)
        {
            this.id = Convert.ToInt32(data["id"]);
            this.level_id = Convert.ToInt32(data["level_id"]);
            this.desc = Convert.ToString(data["desc"]);
            this.type = Convert.ToInt32(data["type"]);
            this.param1 = Convert.ToInt32(data["param1"]);
            this.param2 = Convert.ToInt32(data["param2"]);
            this.score = Convert.ToInt32(data["score"]);
            this.exp = Convert.ToInt32(data["exp"]);
            this.gold = Convert.ToInt32(data["gold"]);
            this.ctype = Convert.ToInt32(data["ctype"]);

            return this;
        }
    }

    public class LootItem : SqlDataBase
    {
        // DI
        public int id;
        // 奖励包
        public int pkg_id;
        // 奖励类型
        public int type;
        // 奖励
        public int item_id;
        // 物品参数
        public int item_rev_id;

        public static LootItem Copy(LootItem other)
        {
            LootItem ret = new LootItem();
            ret.id = other.id;
            ret.pkg_id = other.pkg_id;
            ret.type = other.type;
            ret.item_id = other.item_id;
            ret.item_rev_id = other.item_rev_id;

            return ret;
        }

        public override SqlDataBase InitWithAttributes(Dictionary<string, System.Object> data)
        {
            this.id = Convert.ToInt32(data["id"]);
            this.pkg_id = Convert.ToInt32(data["pkg_id"]);
            this.type = Convert.ToInt32(data["type"]);
            this.item_id = Convert.ToInt32(data["item_id"]);
            this.item_rev_id = Convert.ToInt32(data["item_rev_id"]);

            return this;
        }
    }

    public class ChallengeLevel : SqlDataBase
    {
        // 关卡ID
        public int id;
        // 场景ID
        public int scene_id;
        // 掩体等级
        public int lv_bunker;
        // 关卡类型
        public int levelType;
        // 时间积分系数
        public int duration_factor;
        // 最小时间
        public int min_duration;
        // 最大时间
        public int max_duration;
        // 第1关掉落包
        public int pkg1;
        // 第1关掉落包
        public int pkg2;
        // 第2关掉落包
        public int pkg3;
        // 第2关掉落包
        public int pkg4;
        // 第3关掉落包
        public int pkg5;
        // 第3关掉落包
        public int pkg6;

        public static ChallengeLevel Copy(ChallengeLevel other)
        {
            ChallengeLevel ret = new ChallengeLevel();
            ret.id = other.id;
            ret.scene_id = other.scene_id;
            ret.lv_bunker = other.lv_bunker;
            ret.levelType = other.levelType;
            ret.duration_factor = other.duration_factor;
            ret.min_duration = other.min_duration;
            ret.max_duration = other.max_duration;
            ret.pkg1 = other.pkg1;
            ret.pkg2 = other.pkg2;
            ret.pkg3 = other.pkg3;
            ret.pkg4 = other.pkg4;
            ret.pkg5 = other.pkg5;
            ret.pkg6 = other.pkg6;

            return ret;
        }

        public override SqlDataBase InitWithAttributes(Dictionary<string, System.Object> data)
        {
            this.id = Convert.ToInt32(data["id"]);
            this.scene_id = Convert.ToInt32(data["scene_id"]);
            this.lv_bunker = Convert.ToInt32(data["lv_bunker"]);
            this.levelType = Convert.ToInt32(data["levelType"]);
            this.duration_factor = Convert.ToInt32(data["duration_factor"]);
            this.min_duration = Convert.ToInt32(data["min_duration"]);
            this.max_duration = Convert.ToInt32(data["max_duration"]);
            this.pkg1 = Convert.ToInt32(data["pkg1"]);
            this.pkg2 = Convert.ToInt32(data["pkg2"]);
            this.pkg3 = Convert.ToInt32(data["pkg3"]);
            this.pkg4 = Convert.ToInt32(data["pkg4"]);
            this.pkg5 = Convert.ToInt32(data["pkg5"]);
            this.pkg6 = Convert.ToInt32(data["pkg6"]);

            return this;
        }
    }

    public class Challenge : SqlDataBase
    {
        // 关卡顺序
        public int id;
        // 随机关卡数量
        public int level_count;
        // 挑战币
        public int chlg_gold;
        // 金币
        public int gold;
        // iLevelBaseGrade
        public int grade;
        // 关卡ID
        public int level_1;
        // 特殊关卡
        public int special_1;
        // 关卡ID
        public int level_2;
        // 特殊关卡
        public int special_2;
        // 关卡ID
        public int level_3;
        // 特殊关卡
        public int special_3;
        // 关卡ID
        public int level_4;
        // 特殊关卡
        public int special_4;
        // 关卡ID
        public int level_5;
        // 特殊关卡
        public int special_5;
        // 关卡ID
        public int level_6;
        // 特殊关卡
        public int special_6;
        // 关卡ID
        public int level_7;
        // 特殊关卡
        public int special_7;

        public static Challenge Copy(Challenge other)
        {
            Challenge ret = new Challenge();
            ret.id = other.id;
            ret.level_count = other.level_count;
            ret.chlg_gold = other.chlg_gold;
            ret.gold = other.gold;
            ret.grade = other.grade;
            ret.level_1 = other.level_1;
            ret.special_1 = other.special_1;
            ret.level_2 = other.level_2;
            ret.special_2 = other.special_2;
            ret.level_3 = other.level_3;
            ret.special_3 = other.special_3;
            ret.level_4 = other.level_4;
            ret.special_4 = other.special_4;
            ret.level_5 = other.level_5;
            ret.special_5 = other.special_5;
            ret.level_6 = other.level_6;
            ret.special_6 = other.special_6;
            ret.level_7 = other.level_7;
            ret.special_7 = other.special_7;

            return ret;
        }

        public override SqlDataBase InitWithAttributes(Dictionary<string, System.Object> data)
        {
            this.id = Convert.ToInt32(data["id"]);
            this.level_count = Convert.ToInt32(data["level_count"]);
            this.chlg_gold = Convert.ToInt32(data["chlg_gold"]);
            this.gold = Convert.ToInt32(data["gold"]);
            this.grade = Convert.ToInt32(data["grade"]);
            this.level_1 = Convert.ToInt32(data["level_1"]);
            this.special_1 = Convert.ToInt32(data["special_1"]);
            this.level_2 = Convert.ToInt32(data["level_2"]);
            this.special_2 = Convert.ToInt32(data["special_2"]);
            this.level_3 = Convert.ToInt32(data["level_3"]);
            this.special_3 = Convert.ToInt32(data["special_3"]);
            this.level_4 = Convert.ToInt32(data["level_4"]);
            this.special_4 = Convert.ToInt32(data["special_4"]);
            this.level_5 = Convert.ToInt32(data["level_5"]);
            this.special_5 = Convert.ToInt32(data["special_5"]);
            this.level_6 = Convert.ToInt32(data["level_6"]);
            this.special_6 = Convert.ToInt32(data["special_6"]);
            this.level_7 = Convert.ToInt32(data["level_7"]);
            this.special_7 = Convert.ToInt32(data["special_7"]);

            return this;
        }
    }

    public class DropGuide : SqlDataBase
    {
        // 道具ID
        public int id;
        // 关卡ID1
        public int sl1;
        // 关卡ID2
        public int sl2;
        // 关卡ID3
        public int sl3;
        // 关卡ID4
        public int sl4;
        // 关卡ID5
        public int sl5;
        // 关卡ID6
        public int sl6;

        public static DropGuide Copy(DropGuide other)
        {
            DropGuide ret = new DropGuide();
            ret.id = other.id;
            ret.sl1 = other.sl1;
            ret.sl2 = other.sl2;
            ret.sl3 = other.sl3;
            ret.sl4 = other.sl4;
            ret.sl5 = other.sl5;
            ret.sl6 = other.sl6;

            return ret;
        }

        public override SqlDataBase InitWithAttributes(Dictionary<string, System.Object> data)
        {
            this.id = Convert.ToInt32(data["id"]);
            this.sl1 = Convert.ToInt32(data["sl1"]);
            this.sl2 = Convert.ToInt32(data["sl2"]);
            this.sl3 = Convert.ToInt32(data["sl3"]);
            this.sl4 = Convert.ToInt32(data["sl4"]);
            this.sl5 = Convert.ToInt32(data["sl5"]);
            this.sl6 = Convert.ToInt32(data["sl6"]);

            return this;
        }
    }

    public class FragmentCompose : SqlDataBase
    {
        // 序号
        public int id;
        // 道具ID
        public int source_id;
        // 合成枪械
        public int target_id;
        // 合成品阶
        public int rev_id;
        // 合成需求数量
        public int count;

        public static FragmentCompose Copy(FragmentCompose other)
        {
            FragmentCompose ret = new FragmentCompose();
            ret.id = other.id;
            ret.source_id = other.source_id;
            ret.target_id = other.target_id;
            ret.rev_id = other.rev_id;
            ret.count = other.count;

            return ret;
        }

        public override SqlDataBase InitWithAttributes(Dictionary<string, System.Object> data)
        {
            this.id = Convert.ToInt32(data["id"]);
            this.source_id = Convert.ToInt32(data["source_id"]);
            this.target_id = Convert.ToInt32(data["target_id"]);
            this.rev_id = Convert.ToInt32(data["rev_id"]);
            this.count = Convert.ToInt32(data["count"]);

            return this;
        }
    }

    public class BotProp : SqlDataBase
    {
        // 怪物类型
        public int id;
        // 基础血量
        public float fBaseHP;
        // 血量成长
        public float fGrowHP;
        // 基础伤害
        public float fBaseDamage;
        // 伤害成长
        public float fGrowDamage;
        // 基础防御
        public float fBaseArmor;
        // 防御成长
        public float fGrowArmor;
        // 基础技能伤害
        public float fBaseSkillDamage;
        // 技能伤害成长
        public float fGrowSkillDamage;
        // 命中率
        public float fHitPercent;

        public static BotProp Copy(BotProp other)
        {
            BotProp ret = new BotProp();
            ret.id = other.id;
            ret.fBaseHP = other.fBaseHP;
            ret.fGrowHP = other.fGrowHP;
            ret.fBaseDamage = other.fBaseDamage;
            ret.fGrowDamage = other.fGrowDamage;
            ret.fBaseArmor = other.fBaseArmor;
            ret.fGrowArmor = other.fGrowArmor;
            ret.fBaseSkillDamage = other.fBaseSkillDamage;
            ret.fGrowSkillDamage = other.fGrowSkillDamage;
            ret.fHitPercent = other.fHitPercent;

            return ret;
        }

        public override SqlDataBase InitWithAttributes(Dictionary<string, System.Object> data)
        {
            this.id = Convert.ToInt32(data["id"]);
            this.fBaseHP = Convert.ToSingle(data["fBaseHP"]);
            this.fGrowHP = Convert.ToSingle(data["fGrowHP"]);
            this.fBaseDamage = Convert.ToSingle(data["fBaseDamage"]);
            this.fGrowDamage = Convert.ToSingle(data["fGrowDamage"]);
            this.fBaseArmor = Convert.ToSingle(data["fBaseArmor"]);
            this.fGrowArmor = Convert.ToSingle(data["fGrowArmor"]);
            this.fBaseSkillDamage = Convert.ToSingle(data["fBaseSkillDamage"]);
            this.fGrowSkillDamage = Convert.ToSingle(data["fGrowSkillDamage"]);
            this.fHitPercent = Convert.ToSingle(data["fHitPercent"]);

            return this;
        }
    }

    public class BotAIConfig : SqlDataBase
    {
        // AI类型
        public int id;
        // 躲避反应手雷时间
        public float fAvoidGrenadeReactionTime;
        // 躲避手雷几率
        public float fAvoidGrenadeProbability;
        // 躲避反应火箭筒时间
        public float fAvoidRocketReactionTime;
        // 躲避火箭筒几率
        public float fAvoidRocketProbability;
        // 躲避瞄准时间
        public float fAvoidAimingReactionTime;
        // 躲避瞄准几率
        public float fAvoidAimingProbability;
        // 寻找目标时间
        public float fSeekEnemyTime;
        // 躲避射击时间
        public float fAvoidShootReactionTime;
        // 躲避射击几率
        public float fAvoidShootProbability;
        // 瞄准时间
        public float fAimmingTime;
        // 玩家站立最大时间
        public float fPlayerStandMaxTime;
        // 玩家下蹲最大时间
        public float fPlayerCrouchMaxTime;
        // 使用技能CD
        public float fCycleUseSkillInterval;
        // 首次使用技能时间
        public float fFirstUseSkillInterval;
        // 最短下蹲时间
        public float fCrouchTimeMin;
        // 最长下蹲时间
        public float fCrouchTimeMax;
        // 射击持续时间
        public float fShootingTime;
        // 扔手雷CD
        public float fThrowGrenadeInterval;
        // 扔火箭筒CD
        public float fLaunchRocketInterval;
        // 寻找射击点CD
        public float fSeekAttackBunkerInterval;
        // 射击CD
        public float fFireInterval;
        // 停止射击CD
        public float fStopFireInterval;

        public static BotAIConfig Copy(BotAIConfig other)
        {
            BotAIConfig ret = new BotAIConfig();
            ret.id = other.id;
            ret.fAvoidGrenadeReactionTime = other.fAvoidGrenadeReactionTime;
            ret.fAvoidGrenadeProbability = other.fAvoidGrenadeProbability;
            ret.fAvoidRocketReactionTime = other.fAvoidRocketReactionTime;
            ret.fAvoidRocketProbability = other.fAvoidRocketProbability;
            ret.fAvoidAimingReactionTime = other.fAvoidAimingReactionTime;
            ret.fAvoidAimingProbability = other.fAvoidAimingProbability;
            ret.fSeekEnemyTime = other.fSeekEnemyTime;
            ret.fAvoidShootReactionTime = other.fAvoidShootReactionTime;
            ret.fAvoidShootProbability = other.fAvoidShootProbability;
            ret.fAimmingTime = other.fAimmingTime;
            ret.fPlayerStandMaxTime = other.fPlayerStandMaxTime;
            ret.fPlayerCrouchMaxTime = other.fPlayerCrouchMaxTime;
            ret.fCycleUseSkillInterval = other.fCycleUseSkillInterval;
            ret.fFirstUseSkillInterval = other.fFirstUseSkillInterval;
            ret.fCrouchTimeMin = other.fCrouchTimeMin;
            ret.fCrouchTimeMax = other.fCrouchTimeMax;
            ret.fShootingTime = other.fShootingTime;
            ret.fThrowGrenadeInterval = other.fThrowGrenadeInterval;
            ret.fLaunchRocketInterval = other.fLaunchRocketInterval;
            ret.fSeekAttackBunkerInterval = other.fSeekAttackBunkerInterval;
            ret.fFireInterval = other.fFireInterval;
            ret.fStopFireInterval = other.fStopFireInterval;

            return ret;
        }

        public override SqlDataBase InitWithAttributes(Dictionary<string, System.Object> data)
        {
            this.id = Convert.ToInt32(data["id"]);
            this.fAvoidGrenadeReactionTime = Convert.ToSingle(data["fAvoidGrenadeReactionTime"]);
            this.fAvoidGrenadeProbability = Convert.ToSingle(data["fAvoidGrenadeProbability"]);
            this.fAvoidRocketReactionTime = Convert.ToSingle(data["fAvoidRocketReactionTime"]);
            this.fAvoidRocketProbability = Convert.ToSingle(data["fAvoidRocketProbability"]);
            this.fAvoidAimingReactionTime = Convert.ToSingle(data["fAvoidAimingReactionTime"]);
            this.fAvoidAimingProbability = Convert.ToSingle(data["fAvoidAimingProbability"]);
            this.fSeekEnemyTime = Convert.ToSingle(data["fSeekEnemyTime"]);
            this.fAvoidShootReactionTime = Convert.ToSingle(data["fAvoidShootReactionTime"]);
            this.fAvoidShootProbability = Convert.ToSingle(data["fAvoidShootProbability"]);
            this.fAimmingTime = Convert.ToSingle(data["fAimmingTime"]);
            this.fPlayerStandMaxTime = Convert.ToSingle(data["fPlayerStandMaxTime"]);
            this.fPlayerCrouchMaxTime = Convert.ToSingle(data["fPlayerCrouchMaxTime"]);
            this.fCycleUseSkillInterval = Convert.ToSingle(data["fCycleUseSkillInterval"]);
            this.fFirstUseSkillInterval = Convert.ToSingle(data["fFirstUseSkillInterval"]);
            this.fCrouchTimeMin = Convert.ToSingle(data["fCrouchTimeMin"]);
            this.fCrouchTimeMax = Convert.ToSingle(data["fCrouchTimeMax"]);
            this.fShootingTime = Convert.ToSingle(data["fShootingTime"]);
            this.fThrowGrenadeInterval = Convert.ToSingle(data["fThrowGrenadeInterval"]);
            this.fLaunchRocketInterval = Convert.ToSingle(data["fLaunchRocketInterval"]);
            this.fSeekAttackBunkerInterval = Convert.ToSingle(data["fSeekAttackBunkerInterval"]);
            this.fFireInterval = Convert.ToSingle(data["fFireInterval"]);
            this.fStopFireInterval = Convert.ToSingle(data["fStopFireInterval"]);

            return this;
        }
    }

    public class BotBase : SqlDataBase
    {
        // 怪物ID
        public int id;
        // 怪物等级
        public int iLevel;
        // 怪物模型
        public string szPrefabPath;
        // 单位类型
        public int iUnitType;
        // 怪物名称
        public string szDisplayName;
        // 名称颜色
        public string szTitle;
        // 怪物类型
        public int iAttrType;
        // AI类型
        public int iAIID;
        // 移动速度
        public float fMoveSpeed;
        // 携带武器
        public int iMainWeaponResId;
        // 血量系数
        public float fHealthFactor;
        // 伤害系数
        public float fDamageFactor;
        // 命中率
        public float fHitRateFactor;
        // 技能系数
        public float fSkillPowerFactor;
        // 奖励积分系数
        public float fRewardScoreFactor;
        // 奖励金币系数
        public float fRewardGoldFactor;
        // 奖励钻石系数
        public float fRewardDiamondFactor;
        // 标签
        public int iTag;
        // BOSS路线
        public string szRoute;
        // 特殊攻击点
        public string szActionAttackPos;
        // 是否特写
        public int iIsShowCamera;
        // 特写时间
        public float fShowCameraTime;
        // 是否播放出生动画
        public int iPlaySpawnAnim;
        // 出生动画播放时间
        public float fSpawnAnimDuration;
        // 图标
        public string szIconID;
        // 头顶图标
        public string szHeadIconID;
        // 掉落表Id
        public int iDropItemTableID;
        // 佣兵仇恨值
        public float fHateValue4Mercenary;
        // 技能类型
        public int iSkillType;
        // 技能ID
        public int iSkillID;
        // 技能类型
        public int iSkillType1;
        // 技能ID
        public int iSkillID1;
        // 技能类型
        public int iSkillType2;
        // 技能ID
        public int iSkillID2;
        // 技能类型
        public int iSkillType3;
        // 技能ID
        public int iSkillID3;

        public static BotBase Copy(BotBase other)
        {
            BotBase ret = new BotBase();
            ret.id = other.id;
            ret.iLevel = other.iLevel;
            ret.szPrefabPath = other.szPrefabPath;
            ret.iUnitType = other.iUnitType;
            ret.szDisplayName = other.szDisplayName;
            ret.szTitle = other.szTitle;
            ret.iAttrType = other.iAttrType;
            ret.iAIID = other.iAIID;
            ret.fMoveSpeed = other.fMoveSpeed;
            ret.iMainWeaponResId = other.iMainWeaponResId;
            ret.fHealthFactor = other.fHealthFactor;
            ret.fDamageFactor = other.fDamageFactor;
            ret.fHitRateFactor = other.fHitRateFactor;
            ret.fSkillPowerFactor = other.fSkillPowerFactor;
            ret.fRewardScoreFactor = other.fRewardScoreFactor;
            ret.fRewardGoldFactor = other.fRewardGoldFactor;
            ret.fRewardDiamondFactor = other.fRewardDiamondFactor;
            ret.iTag = other.iTag;
            ret.szRoute = other.szRoute;
            ret.szActionAttackPos = other.szActionAttackPos;
            ret.iIsShowCamera = other.iIsShowCamera;
            ret.fShowCameraTime = other.fShowCameraTime;
            ret.iPlaySpawnAnim = other.iPlaySpawnAnim;
            ret.fSpawnAnimDuration = other.fSpawnAnimDuration;
            ret.szIconID = other.szIconID;
            ret.szHeadIconID = other.szHeadIconID;
            ret.iDropItemTableID = other.iDropItemTableID;
            ret.fHateValue4Mercenary = other.fHateValue4Mercenary;
            ret.iSkillType = other.iSkillType;
            ret.iSkillID = other.iSkillID;
            ret.iSkillType1 = other.iSkillType1;
            ret.iSkillID1 = other.iSkillID1;
            ret.iSkillType2 = other.iSkillType2;
            ret.iSkillID2 = other.iSkillID2;
            ret.iSkillType3 = other.iSkillType3;
            ret.iSkillID3 = other.iSkillID3;

            return ret;
        }

        public override SqlDataBase InitWithAttributes(Dictionary<string, System.Object> data)
        {
            this.id = Convert.ToInt32(data["id"]);
            this.iLevel = Convert.ToInt32(data["iLevel"]);
            this.szPrefabPath = Convert.ToString(data["szPrefabPath"]);
            this.iUnitType = Convert.ToInt32(data["iUnitType"]);
            this.szDisplayName = Convert.ToString(data["szDisplayName"]);
            this.szTitle = Convert.ToString(data["szTitle"]);
            this.iAttrType = Convert.ToInt32(data["iAttrType"]);
            this.iAIID = Convert.ToInt32(data["iAIID"]);
            this.fMoveSpeed = Convert.ToSingle(data["fMoveSpeed"]);
            this.iMainWeaponResId = Convert.ToInt32(data["iMainWeaponResId"]);
            this.fHealthFactor = Convert.ToSingle(data["fHealthFactor"]);
            this.fDamageFactor = Convert.ToSingle(data["fDamageFactor"]);
            this.fHitRateFactor = Convert.ToSingle(data["fHitRateFactor"]);
            this.fSkillPowerFactor = Convert.ToSingle(data["fSkillPowerFactor"]);
            this.fRewardScoreFactor = Convert.ToSingle(data["fRewardScoreFactor"]);
            this.fRewardGoldFactor = Convert.ToSingle(data["fRewardGoldFactor"]);
            this.fRewardDiamondFactor = Convert.ToSingle(data["fRewardDiamondFactor"]);
            this.iTag = Convert.ToInt32(data["iTag"]);
            this.szRoute = Convert.ToString(data["szRoute"]);
            this.szActionAttackPos = Convert.ToString(data["szActionAttackPos"]);
            this.iIsShowCamera = Convert.ToInt32(data["iIsShowCamera"]);
            this.fShowCameraTime = Convert.ToSingle(data["fShowCameraTime"]);
            this.iPlaySpawnAnim = Convert.ToInt32(data["iPlaySpawnAnim"]);
            this.fSpawnAnimDuration = Convert.ToSingle(data["fSpawnAnimDuration"]);
            this.szIconID = Convert.ToString(data["szIconID"]);
            this.szHeadIconID = Convert.ToString(data["szHeadIconID"]);
            this.iDropItemTableID = Convert.ToInt32(data["iDropItemTableID"]);
            this.fHateValue4Mercenary = Convert.ToSingle(data["fHateValue4Mercenary"]);
            this.iSkillType = Convert.ToInt32(data["iSkillType"]);
            this.iSkillID = Convert.ToInt32(data["iSkillID"]);
            this.iSkillType1 = Convert.ToInt32(data["iSkillType1"]);
            this.iSkillID1 = Convert.ToInt32(data["iSkillID1"]);
            this.iSkillType2 = Convert.ToInt32(data["iSkillType2"]);
            this.iSkillID2 = Convert.ToInt32(data["iSkillID2"]);
            this.iSkillType3 = Convert.ToInt32(data["iSkillType3"]);
            this.iSkillID3 = Convert.ToInt32(data["iSkillID3"]);

            return this;
        }
    }

    public class ChallengeDropCfg : SqlDataBase
    {
        // 
        public int id;
        // 
        public float fProbability;
        // 
        public int iDropTypeNum;
        // 
        public int iItemType1;
        // 
        public int iItemID1;
        // 
        public int iRevID1;
        // 
        public int iItemWeight1;
        // 
        public int iItemType2;
        // 
        public int iItemID2;
        // 
        public int iRevID2;
        // 
        public int iItemWeight2;
        // 
        public int iItemType3;
        // 
        public int iItemID3;
        // 
        public int iRevID3;
        // 
        public int iItemWeight3;
        // 
        public int iItemType4;
        // 
        public int iItemID4;
        // 
        public int iRevID4;
        // 
        public int iItemWeight4;
        // 
        public int iItemType5;
        // 
        public int iItemID5;
        // 
        public int iRevID5;
        // 
        public int iItemWeight5;
        // 
        public int iItemType6;
        // 
        public int iItemID6;
        // 
        public int iRevID6;
        // 
        public int iItemWeight6;
        // 
        public int iItemType7;
        // 
        public int iItemID7;
        // 
        public int iRevID7;
        // 
        public int iItemWeight7;
        // 
        public int iItemType8;
        // 
        public int iItemID8;
        // 
        public int iRevID8;
        // 
        public int iItemWeight8;
        // 
        public int iItemType9;
        // 
        public int iItemID9;
        // 
        public int iRevID9;
        // 
        public int iItemWeight9;
        // 
        public int iItemType10;
        // 
        public int iItemID10;
        // 
        public int iRevID10;
        // 
        public int iItemWeight10;

        public static ChallengeDropCfg Copy(ChallengeDropCfg other)
        {
            ChallengeDropCfg ret = new ChallengeDropCfg();
            ret.id = other.id;
            ret.fProbability = other.fProbability;
            ret.iDropTypeNum = other.iDropTypeNum;
            ret.iItemType1 = other.iItemType1;
            ret.iItemID1 = other.iItemID1;
            ret.iRevID1 = other.iRevID1;
            ret.iItemWeight1 = other.iItemWeight1;
            ret.iItemType2 = other.iItemType2;
            ret.iItemID2 = other.iItemID2;
            ret.iRevID2 = other.iRevID2;
            ret.iItemWeight2 = other.iItemWeight2;
            ret.iItemType3 = other.iItemType3;
            ret.iItemID3 = other.iItemID3;
            ret.iRevID3 = other.iRevID3;
            ret.iItemWeight3 = other.iItemWeight3;
            ret.iItemType4 = other.iItemType4;
            ret.iItemID4 = other.iItemID4;
            ret.iRevID4 = other.iRevID4;
            ret.iItemWeight4 = other.iItemWeight4;
            ret.iItemType5 = other.iItemType5;
            ret.iItemID5 = other.iItemID5;
            ret.iRevID5 = other.iRevID5;
            ret.iItemWeight5 = other.iItemWeight5;
            ret.iItemType6 = other.iItemType6;
            ret.iItemID6 = other.iItemID6;
            ret.iRevID6 = other.iRevID6;
            ret.iItemWeight6 = other.iItemWeight6;
            ret.iItemType7 = other.iItemType7;
            ret.iItemID7 = other.iItemID7;
            ret.iRevID7 = other.iRevID7;
            ret.iItemWeight7 = other.iItemWeight7;
            ret.iItemType8 = other.iItemType8;
            ret.iItemID8 = other.iItemID8;
            ret.iRevID8 = other.iRevID8;
            ret.iItemWeight8 = other.iItemWeight8;
            ret.iItemType9 = other.iItemType9;
            ret.iItemID9 = other.iItemID9;
            ret.iRevID9 = other.iRevID9;
            ret.iItemWeight9 = other.iItemWeight9;
            ret.iItemType10 = other.iItemType10;
            ret.iItemID10 = other.iItemID10;
            ret.iRevID10 = other.iRevID10;
            ret.iItemWeight10 = other.iItemWeight10;

            return ret;
        }

        public override SqlDataBase InitWithAttributes(Dictionary<string, System.Object> data)
        {
            this.id = Convert.ToInt32(data["id"]);
            this.fProbability = Convert.ToSingle(data["fProbability"]);
            this.iDropTypeNum = Convert.ToInt32(data["iDropTypeNum"]);
            this.iItemType1 = Convert.ToInt32(data["iItemType1"]);
            this.iItemID1 = Convert.ToInt32(data["iItemID1"]);
            this.iRevID1 = Convert.ToInt32(data["iRevID1"]);
            this.iItemWeight1 = Convert.ToInt32(data["iItemWeight1"]);
            this.iItemType2 = Convert.ToInt32(data["iItemType2"]);
            this.iItemID2 = Convert.ToInt32(data["iItemID2"]);
            this.iRevID2 = Convert.ToInt32(data["iRevID2"]);
            this.iItemWeight2 = Convert.ToInt32(data["iItemWeight2"]);
            this.iItemType3 = Convert.ToInt32(data["iItemType3"]);
            this.iItemID3 = Convert.ToInt32(data["iItemID3"]);
            this.iRevID3 = Convert.ToInt32(data["iRevID3"]);
            this.iItemWeight3 = Convert.ToInt32(data["iItemWeight3"]);
            this.iItemType4 = Convert.ToInt32(data["iItemType4"]);
            this.iItemID4 = Convert.ToInt32(data["iItemID4"]);
            this.iRevID4 = Convert.ToInt32(data["iRevID4"]);
            this.iItemWeight4 = Convert.ToInt32(data["iItemWeight4"]);
            this.iItemType5 = Convert.ToInt32(data["iItemType5"]);
            this.iItemID5 = Convert.ToInt32(data["iItemID5"]);
            this.iRevID5 = Convert.ToInt32(data["iRevID5"]);
            this.iItemWeight5 = Convert.ToInt32(data["iItemWeight5"]);
            this.iItemType6 = Convert.ToInt32(data["iItemType6"]);
            this.iItemID6 = Convert.ToInt32(data["iItemID6"]);
            this.iRevID6 = Convert.ToInt32(data["iRevID6"]);
            this.iItemWeight6 = Convert.ToInt32(data["iItemWeight6"]);
            this.iItemType7 = Convert.ToInt32(data["iItemType7"]);
            this.iItemID7 = Convert.ToInt32(data["iItemID7"]);
            this.iRevID7 = Convert.ToInt32(data["iRevID7"]);
            this.iItemWeight7 = Convert.ToInt32(data["iItemWeight7"]);
            this.iItemType8 = Convert.ToInt32(data["iItemType8"]);
            this.iItemID8 = Convert.ToInt32(data["iItemID8"]);
            this.iRevID8 = Convert.ToInt32(data["iRevID8"]);
            this.iItemWeight8 = Convert.ToInt32(data["iItemWeight8"]);
            this.iItemType9 = Convert.ToInt32(data["iItemType9"]);
            this.iItemID9 = Convert.ToInt32(data["iItemID9"]);
            this.iRevID9 = Convert.ToInt32(data["iRevID9"]);
            this.iItemWeight9 = Convert.ToInt32(data["iItemWeight9"]);
            this.iItemType10 = Convert.ToInt32(data["iItemType10"]);
            this.iItemID10 = Convert.ToInt32(data["iItemID10"]);
            this.iRevID10 = Convert.ToInt32(data["iRevID10"]);
            this.iItemWeight10 = Convert.ToInt32(data["iItemWeight10"]);

            return this;
        }
    }

    public class LeveLScore : SqlDataBase
    {
        // id
        public int id;
        // 敌方等级
        public int iSoldierLevel;
        // 基础积分
        public int fKilledScore;
        // 爆头积分
        public int fShootHeadScore;
        // 连杀积分
        public int fMultiKilledScore;

        public static LeveLScore Copy(LeveLScore other)
        {
            LeveLScore ret = new LeveLScore();
            ret.id = other.id;
            ret.iSoldierLevel = other.iSoldierLevel;
            ret.fKilledScore = other.fKilledScore;
            ret.fShootHeadScore = other.fShootHeadScore;
            ret.fMultiKilledScore = other.fMultiKilledScore;

            return ret;
        }

        public override SqlDataBase InitWithAttributes(Dictionary<string, System.Object> data)
        {
            this.id = Convert.ToInt32(data["id"]);
            this.iSoldierLevel = Convert.ToInt32(data["iSoldierLevel"]);
            this.fKilledScore = Convert.ToInt32(data["fKilledScore"]);
            this.fShootHeadScore = Convert.ToInt32(data["fShootHeadScore"]);
            this.fMultiKilledScore = Convert.ToInt32(data["fMultiKilledScore"]);

            return this;
        }
    }

    public class VehicleInfo : SqlDataBase
    {
        // 
        public int id;
        // 
        public int iLevel;
        // 
        public string szPrefabPath;
        // 
        public int iUnitType;
        // 
        public string szDisplayName;
        // 
        public int iAttrType;
        // 
        public float fMoveSpeed;
        // 
        public int iMainWeaponResId;
        // 
        public int iSkillResId;
        // 
        public float fHealthFactor;
        // 
        public float fDamageFactor;
        // 
        public float fHitRateFactor;
        // 
        public float fRewardScoreFactor;
        // 
        public float fRewardGoldFactor;
        // 
        public float fRewardDiamondFactor;
        // 
        public int iTag;
        // 
        public int iIsShowCamera;
        // 
        public float fShowCameraTime;
        // 
        public string szShowCameraText;
        // 
        public int iTeamNum;
        // 
        public int iIsUseIncLevel;
        // 
        public int iIncLevelDelta;

        public static VehicleInfo Copy(VehicleInfo other)
        {
            VehicleInfo ret = new VehicleInfo();
            ret.id = other.id;
            ret.iLevel = other.iLevel;
            ret.szPrefabPath = other.szPrefabPath;
            ret.iUnitType = other.iUnitType;
            ret.szDisplayName = other.szDisplayName;
            ret.iAttrType = other.iAttrType;
            ret.fMoveSpeed = other.fMoveSpeed;
            ret.iMainWeaponResId = other.iMainWeaponResId;
            ret.iSkillResId = other.iSkillResId;
            ret.fHealthFactor = other.fHealthFactor;
            ret.fDamageFactor = other.fDamageFactor;
            ret.fHitRateFactor = other.fHitRateFactor;
            ret.fRewardScoreFactor = other.fRewardScoreFactor;
            ret.fRewardGoldFactor = other.fRewardGoldFactor;
            ret.fRewardDiamondFactor = other.fRewardDiamondFactor;
            ret.iTag = other.iTag;
            ret.iIsShowCamera = other.iIsShowCamera;
            ret.fShowCameraTime = other.fShowCameraTime;
            ret.szShowCameraText = other.szShowCameraText;
            ret.iTeamNum = other.iTeamNum;
            ret.iIsUseIncLevel = other.iIsUseIncLevel;
            ret.iIncLevelDelta = other.iIncLevelDelta;

            return ret;
        }

        public override SqlDataBase InitWithAttributes(Dictionary<string, System.Object> data)
        {
            this.id = Convert.ToInt32(data["id"]);
            this.iLevel = Convert.ToInt32(data["iLevel"]);
            this.szPrefabPath = Convert.ToString(data["szPrefabPath"]);
            this.iUnitType = Convert.ToInt32(data["iUnitType"]);
            this.szDisplayName = Convert.ToString(data["szDisplayName"]);
            this.iAttrType = Convert.ToInt32(data["iAttrType"]);
            this.fMoveSpeed = Convert.ToSingle(data["fMoveSpeed"]);
            this.iMainWeaponResId = Convert.ToInt32(data["iMainWeaponResId"]);
            this.iSkillResId = Convert.ToInt32(data["iSkillResId"]);
            this.fHealthFactor = Convert.ToSingle(data["fHealthFactor"]);
            this.fDamageFactor = Convert.ToSingle(data["fDamageFactor"]);
            this.fHitRateFactor = Convert.ToSingle(data["fHitRateFactor"]);
            this.fRewardScoreFactor = Convert.ToSingle(data["fRewardScoreFactor"]);
            this.fRewardGoldFactor = Convert.ToSingle(data["fRewardGoldFactor"]);
            this.fRewardDiamondFactor = Convert.ToSingle(data["fRewardDiamondFactor"]);
            this.iTag = Convert.ToInt32(data["iTag"]);
            this.iIsShowCamera = Convert.ToInt32(data["iIsShowCamera"]);
            this.fShowCameraTime = Convert.ToSingle(data["fShowCameraTime"]);
            this.szShowCameraText = Convert.ToString(data["szShowCameraText"]);
            this.iTeamNum = Convert.ToInt32(data["iTeamNum"]);
            this.iIsUseIncLevel = Convert.ToInt32(data["iIsUseIncLevel"]);
            this.iIncLevelDelta = Convert.ToInt32(data["iIncLevelDelta"]);

            return this;
        }
    }

    public class PvpRankLevel : SqlDataBase
    {
        // 段位等级
        public int id;
        // 段位积分
        public int score;
        // 段位积分日常上限
        public int ladder_xp_limit;
        // 军衔经验日常上限
        public int rank_xp_limit;
        // 
        public int pvpgold_match_limit;
        // 
        public int reward_match_limit;
        // 名称
        public string name;
        // 段位对军衔经验的加成
        public float xp_promote;

        public static PvpRankLevel Copy(PvpRankLevel other)
        {
            PvpRankLevel ret = new PvpRankLevel();
            ret.id = other.id;
            ret.score = other.score;
            ret.ladder_xp_limit = other.ladder_xp_limit;
            ret.rank_xp_limit = other.rank_xp_limit;
            ret.pvpgold_match_limit = other.pvpgold_match_limit;
            ret.reward_match_limit = other.reward_match_limit;
            ret.name = other.name;
            ret.xp_promote = other.xp_promote;

            return ret;
        }

        public override SqlDataBase InitWithAttributes(Dictionary<string, System.Object> data)
        {
            this.id = Convert.ToInt32(data["id"]);
            this.score = Convert.ToInt32(data["score"]);
            this.ladder_xp_limit = Convert.ToInt32(data["ladder_xp_limit"]);
            this.rank_xp_limit = Convert.ToInt32(data["rank_xp_limit"]);
            this.pvpgold_match_limit = Convert.ToInt32(data["pvpgold_match_limit"]);
            this.reward_match_limit = Convert.ToInt32(data["reward_match_limit"]);
            this.name = Convert.ToString(data["name"]);
            this.xp_promote = Convert.ToSingle(data["xp_promote"]);

            return this;
        }
    }

    public class ArmyRankLevel : SqlDataBase
    {
        // 军衔等级
        public int id;
        // 经验
        public int xp;
        // 军衔名称
        public string name;

        public static ArmyRankLevel Copy(ArmyRankLevel other)
        {
            ArmyRankLevel ret = new ArmyRankLevel();
            ret.id = other.id;
            ret.xp = other.xp;
            ret.name = other.name;

            return ret;
        }

        public override SqlDataBase InitWithAttributes(Dictionary<string, System.Object> data)
        {
            this.id = Convert.ToInt32(data["id"]);
            this.xp = Convert.ToInt32(data["xp"]);
            this.name = Convert.ToString(data["name"]);

            return this;
        }
    }

    public class VehicleBase : SqlDataBase
    {
        // 
        public int id;
        // 
        public float fBaseSpeed;
        // 
        public float fGrowSpeed;
        // 
        public int iBaseHP;
        // 
        public int iGrowHP;
        // 
        public int iBaseDamage;
        // 
        public int iGrowDamage;
        // 
        public int iBaseArmor;
        // 
        public int iGrowArmor;
        // 
        public int iHitRate;

        public static VehicleBase Copy(VehicleBase other)
        {
            VehicleBase ret = new VehicleBase();
            ret.id = other.id;
            ret.fBaseSpeed = other.fBaseSpeed;
            ret.fGrowSpeed = other.fGrowSpeed;
            ret.iBaseHP = other.iBaseHP;
            ret.iGrowHP = other.iGrowHP;
            ret.iBaseDamage = other.iBaseDamage;
            ret.iGrowDamage = other.iGrowDamage;
            ret.iBaseArmor = other.iBaseArmor;
            ret.iGrowArmor = other.iGrowArmor;
            ret.iHitRate = other.iHitRate;

            return ret;
        }

        public override SqlDataBase InitWithAttributes(Dictionary<string, System.Object> data)
        {
            this.id = Convert.ToInt32(data["id"]);
            this.fBaseSpeed = Convert.ToSingle(data["fBaseSpeed"]);
            this.fGrowSpeed = Convert.ToSingle(data["fGrowSpeed"]);
            this.iBaseHP = Convert.ToInt32(data["iBaseHP"]);
            this.iGrowHP = Convert.ToInt32(data["iGrowHP"]);
            this.iBaseDamage = Convert.ToInt32(data["iBaseDamage"]);
            this.iGrowDamage = Convert.ToInt32(data["iGrowDamage"]);
            this.iBaseArmor = Convert.ToInt32(data["iBaseArmor"]);
            this.iGrowArmor = Convert.ToInt32(data["iGrowArmor"]);
            this.iHitRate = Convert.ToInt32(data["iHitRate"]);

            return this;
        }
    }

    public class PropLimit : SqlDataBase
    {
        // 道具ID
        public int id;
        // 挑战模式
        public int chlg_limit;
        // PVP模式
        public int pvp_limit;
        // 普通闯关
        public int pve_limit;
        // 困难闯关
        public int pve_h_limit;
        // 噩梦闯关
        public int pve_n_limit;
        // 普通合作
        public int MultPveLimitList;

        public static PropLimit Copy(PropLimit other)
        {
            PropLimit ret = new PropLimit();
            ret.id = other.id;
            ret.chlg_limit = other.chlg_limit;
            ret.pvp_limit = other.pvp_limit;
            ret.pve_limit = other.pve_limit;
            ret.pve_h_limit = other.pve_h_limit;
            ret.pve_n_limit = other.pve_n_limit;
            ret.MultPveLimitList = other.MultPveLimitList;

            return ret;
        }

        public override SqlDataBase InitWithAttributes(Dictionary<string, System.Object> data)
        {
            this.id = Convert.ToInt32(data["id"]);
            this.chlg_limit = Convert.ToInt32(data["chlg_limit"]);
            this.pvp_limit = Convert.ToInt32(data["pvp_limit"]);
            this.pve_limit = Convert.ToInt32(data["pve_limit"]);
            this.pve_h_limit = Convert.ToInt32(data["pve_h_limit"]);
            this.pve_n_limit = Convert.ToInt32(data["pve_n_limit"]);
            this.MultPveLimitList = Convert.ToInt32(data["MultPveLimitList"]);

            return this;
        }
    }

    public class PvpBalance : SqlDataBase
    {
        // 
        public int id;
        // 血量基础
        public int hp_base;
        // 血量系数
        public float hp_factor;
        // 步枪系数
        public float type_1;
        // 狙击枪系数
        public float type_2;
        // 霰弹枪系数
        public float type_3;
        // 冲锋枪系数
        public float type_4;
        // 白色系数
        public float quality_1;
        // 绿色系数
        public float quality_2;
        // 蓝色系数
        public float quality_3;
        // 蓝色系数
        public float quality_4;
        // 蓝色系数
        public float quality_5;
        // 紫色系数
        public float quality_6;
        // 紫色系数
        public float quality_7;
        // 紫色系数
        public float quality_8;
        // 紫色系数
        public float quality_9;
        // 
        public float quality_10;

        public static PvpBalance Copy(PvpBalance other)
        {
            PvpBalance ret = new PvpBalance();
            ret.id = other.id;
            ret.hp_base = other.hp_base;
            ret.hp_factor = other.hp_factor;
            ret.type_1 = other.type_1;
            ret.type_2 = other.type_2;
            ret.type_3 = other.type_3;
            ret.type_4 = other.type_4;
            ret.quality_1 = other.quality_1;
            ret.quality_2 = other.quality_2;
            ret.quality_3 = other.quality_3;
            ret.quality_4 = other.quality_4;
            ret.quality_5 = other.quality_5;
            ret.quality_6 = other.quality_6;
            ret.quality_7 = other.quality_7;
            ret.quality_8 = other.quality_8;
            ret.quality_9 = other.quality_9;
            ret.quality_10 = other.quality_10;

            return ret;
        }

        public override SqlDataBase InitWithAttributes(Dictionary<string, System.Object> data)
        {
            this.id = Convert.ToInt32(data["id"]);
            this.hp_base = Convert.ToInt32(data["hp_base"]);
            this.hp_factor = Convert.ToSingle(data["hp_factor"]);
            this.type_1 = Convert.ToSingle(data["type_1"]);
            this.type_2 = Convert.ToSingle(data["type_2"]);
            this.type_3 = Convert.ToSingle(data["type_3"]);
            this.type_4 = Convert.ToSingle(data["type_4"]);
            this.quality_1 = Convert.ToSingle(data["quality_1"]);
            this.quality_2 = Convert.ToSingle(data["quality_2"]);
            this.quality_3 = Convert.ToSingle(data["quality_3"]);
            this.quality_4 = Convert.ToSingle(data["quality_4"]);
            this.quality_5 = Convert.ToSingle(data["quality_5"]);
            this.quality_6 = Convert.ToSingle(data["quality_6"]);
            this.quality_7 = Convert.ToSingle(data["quality_7"]);
            this.quality_8 = Convert.ToSingle(data["quality_8"]);
            this.quality_9 = Convert.ToSingle(data["quality_9"]);
            this.quality_10 = Convert.ToSingle(data["quality_10"]);

            return this;
        }
    }

    public class AiOfflineConfig : SqlDataBase
    {
        // 
        public int id;
        // 
        public float fAvoidGrenadeReactionTime;
        // 
        public float fAvoidGrenadeProbability;
        // 
        public float fAvoidRocketReactionTime;
        // 
        public float fAvoidRocketProbability;
        // 
        public float fAvoidAimingReactionTime;
        // 
        public float fAvoidAimingProbability;
        // 
        public float fSeekEnemyTime;
        // 
        public float fAvoidShootReactionTime;
        // 
        public float fAvoidShootProbability;
        // 
        public float fAimmingTime;
        // 
        public float fCrouchTimeMin;
        // 
        public float fCrouchTimeMax;
        // 
        public int iMinBulletNum;
        // 
        public float fShootingAccuracy;
        // 
        public float fHeadShootRate;
        // 
        public float fHealth1Pre;
        // 
        public float fHealth2Pre;
        // 
        public float fHealth3Pre;
        // 
        public float fEnemyLowHealthPre;
        // 
        public int fThrowGrenadeInterval;
        // 
        public int fLaunchRocketInterval;
        // 
        public int iMinELO;

        public static AiOfflineConfig Copy(AiOfflineConfig other)
        {
            AiOfflineConfig ret = new AiOfflineConfig();
            ret.id = other.id;
            ret.fAvoidGrenadeReactionTime = other.fAvoidGrenadeReactionTime;
            ret.fAvoidGrenadeProbability = other.fAvoidGrenadeProbability;
            ret.fAvoidRocketReactionTime = other.fAvoidRocketReactionTime;
            ret.fAvoidRocketProbability = other.fAvoidRocketProbability;
            ret.fAvoidAimingReactionTime = other.fAvoidAimingReactionTime;
            ret.fAvoidAimingProbability = other.fAvoidAimingProbability;
            ret.fSeekEnemyTime = other.fSeekEnemyTime;
            ret.fAvoidShootReactionTime = other.fAvoidShootReactionTime;
            ret.fAvoidShootProbability = other.fAvoidShootProbability;
            ret.fAimmingTime = other.fAimmingTime;
            ret.fCrouchTimeMin = other.fCrouchTimeMin;
            ret.fCrouchTimeMax = other.fCrouchTimeMax;
            ret.iMinBulletNum = other.iMinBulletNum;
            ret.fShootingAccuracy = other.fShootingAccuracy;
            ret.fHeadShootRate = other.fHeadShootRate;
            ret.fHealth1Pre = other.fHealth1Pre;
            ret.fHealth2Pre = other.fHealth2Pre;
            ret.fHealth3Pre = other.fHealth3Pre;
            ret.fEnemyLowHealthPre = other.fEnemyLowHealthPre;
            ret.fThrowGrenadeInterval = other.fThrowGrenadeInterval;
            ret.fLaunchRocketInterval = other.fLaunchRocketInterval;
            ret.iMinELO = other.iMinELO;

            return ret;
        }

        public override SqlDataBase InitWithAttributes(Dictionary<string, System.Object> data)
        {
            this.id = Convert.ToInt32(data["id"]);
            this.fAvoidGrenadeReactionTime = Convert.ToSingle(data["fAvoidGrenadeReactionTime"]);
            this.fAvoidGrenadeProbability = Convert.ToSingle(data["fAvoidGrenadeProbability"]);
            this.fAvoidRocketReactionTime = Convert.ToSingle(data["fAvoidRocketReactionTime"]);
            this.fAvoidRocketProbability = Convert.ToSingle(data["fAvoidRocketProbability"]);
            this.fAvoidAimingReactionTime = Convert.ToSingle(data["fAvoidAimingReactionTime"]);
            this.fAvoidAimingProbability = Convert.ToSingle(data["fAvoidAimingProbability"]);
            this.fSeekEnemyTime = Convert.ToSingle(data["fSeekEnemyTime"]);
            this.fAvoidShootReactionTime = Convert.ToSingle(data["fAvoidShootReactionTime"]);
            this.fAvoidShootProbability = Convert.ToSingle(data["fAvoidShootProbability"]);
            this.fAimmingTime = Convert.ToSingle(data["fAimmingTime"]);
            this.fCrouchTimeMin = Convert.ToSingle(data["fCrouchTimeMin"]);
            this.fCrouchTimeMax = Convert.ToSingle(data["fCrouchTimeMax"]);
            this.iMinBulletNum = Convert.ToInt32(data["iMinBulletNum"]);
            this.fShootingAccuracy = Convert.ToSingle(data["fShootingAccuracy"]);
            this.fHeadShootRate = Convert.ToSingle(data["fHeadShootRate"]);
            this.fHealth1Pre = Convert.ToSingle(data["fHealth1Pre"]);
            this.fHealth2Pre = Convert.ToSingle(data["fHealth2Pre"]);
            this.fHealth3Pre = Convert.ToSingle(data["fHealth3Pre"]);
            this.fEnemyLowHealthPre = Convert.ToSingle(data["fEnemyLowHealthPre"]);
            this.fThrowGrenadeInterval = Convert.ToInt32(data["fThrowGrenadeInterval"]);
            this.fLaunchRocketInterval = Convert.ToInt32(data["fLaunchRocketInterval"]);
            this.iMinELO = Convert.ToInt32(data["iMinELO"]);

            return this;
        }
    }

    public class SkillBase : SqlDataBase
    {
        // 技能ID
        public int id;
        // Prefab
        public string szPrefab;
        // 图标名称
        public string szIconName;
        // 关联道具
        public int iItemResId;
        // 初始化冷却时间
        public float fInitCoolDown;
        // 冷却时间
        public float fCoolDown;
        // 持续时间
        public float fDuration;
        // 主角基础伤害
        public int iPlayerBaseDamage;
        // 主角技能参数
        public float fPlayerSkillFactor;
        // 佣兵基础伤害
        public int iLansquenetBaseDamage;
        // 佣兵技能参数
        public float fLansquenetSkillFactor;
        // 怪物基础伤害
        public int iEnemyBaseDamage;
        // 怪物技能参数
        public float fEnemySkillFactor;
        // 
        public float fKillCommonSolider;
        // 
        public float fKillEliteSolider;
        // 
        public float fKillBossSolider;
        // 
        public int iUnlimitedCase;
        // 
        public int iCallUnitEventID;
        // 
        public float fCallUnitEventDelayTime;
        // 技能范围
        public float fSkillRange;
        // 技能伤害范围
        public float fSkillDamageRange;
        // 技能伤害角度
        public float fSkillDamageAngle;

        public static SkillBase Copy(SkillBase other)
        {
            SkillBase ret = new SkillBase();
            ret.id = other.id;
            ret.szPrefab = other.szPrefab;
            ret.szIconName = other.szIconName;
            ret.iItemResId = other.iItemResId;
            ret.fInitCoolDown = other.fInitCoolDown;
            ret.fCoolDown = other.fCoolDown;
            ret.fDuration = other.fDuration;
            ret.iPlayerBaseDamage = other.iPlayerBaseDamage;
            ret.fPlayerSkillFactor = other.fPlayerSkillFactor;
            ret.iLansquenetBaseDamage = other.iLansquenetBaseDamage;
            ret.fLansquenetSkillFactor = other.fLansquenetSkillFactor;
            ret.iEnemyBaseDamage = other.iEnemyBaseDamage;
            ret.fEnemySkillFactor = other.fEnemySkillFactor;
            ret.fKillCommonSolider = other.fKillCommonSolider;
            ret.fKillEliteSolider = other.fKillEliteSolider;
            ret.fKillBossSolider = other.fKillBossSolider;
            ret.iUnlimitedCase = other.iUnlimitedCase;
            ret.iCallUnitEventID = other.iCallUnitEventID;
            ret.fCallUnitEventDelayTime = other.fCallUnitEventDelayTime;
            ret.fSkillRange = other.fSkillRange;
            ret.fSkillDamageRange = other.fSkillDamageRange;
            ret.fSkillDamageAngle = other.fSkillDamageAngle;

            return ret;
        }

        public override SqlDataBase InitWithAttributes(Dictionary<string, System.Object> data)
        {
            this.id = Convert.ToInt32(data["id"]);
            this.szPrefab = Convert.ToString(data["szPrefab"]);
            this.szIconName = Convert.ToString(data["szIconName"]);
            this.iItemResId = Convert.ToInt32(data["iItemResId"]);
            this.fInitCoolDown = Convert.ToSingle(data["fInitCoolDown"]);
            this.fCoolDown = Convert.ToSingle(data["fCoolDown"]);
            this.fDuration = Convert.ToSingle(data["fDuration"]);
            this.iPlayerBaseDamage = Convert.ToInt32(data["iPlayerBaseDamage"]);
            this.fPlayerSkillFactor = Convert.ToSingle(data["fPlayerSkillFactor"]);
            this.iLansquenetBaseDamage = Convert.ToInt32(data["iLansquenetBaseDamage"]);
            this.fLansquenetSkillFactor = Convert.ToSingle(data["fLansquenetSkillFactor"]);
            this.iEnemyBaseDamage = Convert.ToInt32(data["iEnemyBaseDamage"]);
            this.fEnemySkillFactor = Convert.ToSingle(data["fEnemySkillFactor"]);
            this.fKillCommonSolider = Convert.ToSingle(data["fKillCommonSolider"]);
            this.fKillEliteSolider = Convert.ToSingle(data["fKillEliteSolider"]);
            this.fKillBossSolider = Convert.ToSingle(data["fKillBossSolider"]);
            this.iUnlimitedCase = Convert.ToInt32(data["iUnlimitedCase"]);
            this.iCallUnitEventID = Convert.ToInt32(data["iCallUnitEventID"]);
            this.fCallUnitEventDelayTime = Convert.ToSingle(data["fCallUnitEventDelayTime"]);
            this.fSkillRange = Convert.ToSingle(data["fSkillRange"]);
            this.fSkillDamageRange = Convert.ToSingle(data["fSkillDamageRange"]);
            this.fSkillDamageAngle = Convert.ToSingle(data["fSkillDamageAngle"]);

            return this;
        }
    }

    public class Pvp1v1BotConfig : SqlDataBase
    {
        // 
        public int id;
        // 
        public int rate;
        // 
        public int pvp_lvl_1;
        // 
        public int pvp_lvl_2;
        // 
        public int pvp_lvl_3;
        // 
        public int pvp_lvl_4;
        // 
        public int pvp_lvl_5;
        // 
        public int pvp_lvl_6;

        public static Pvp1v1BotConfig Copy(Pvp1v1BotConfig other)
        {
            Pvp1v1BotConfig ret = new Pvp1v1BotConfig();
            ret.id = other.id;
            ret.rate = other.rate;
            ret.pvp_lvl_1 = other.pvp_lvl_1;
            ret.pvp_lvl_2 = other.pvp_lvl_2;
            ret.pvp_lvl_3 = other.pvp_lvl_3;
            ret.pvp_lvl_4 = other.pvp_lvl_4;
            ret.pvp_lvl_5 = other.pvp_lvl_5;
            ret.pvp_lvl_6 = other.pvp_lvl_6;

            return ret;
        }

        public override SqlDataBase InitWithAttributes(Dictionary<string, System.Object> data)
        {
            this.id = Convert.ToInt32(data["id"]);
            this.rate = Convert.ToInt32(data["rate"]);
            this.pvp_lvl_1 = Convert.ToInt32(data["pvp_lvl_1"]);
            this.pvp_lvl_2 = Convert.ToInt32(data["pvp_lvl_2"]);
            this.pvp_lvl_3 = Convert.ToInt32(data["pvp_lvl_3"]);
            this.pvp_lvl_4 = Convert.ToInt32(data["pvp_lvl_4"]);
            this.pvp_lvl_5 = Convert.ToInt32(data["pvp_lvl_5"]);
            this.pvp_lvl_6 = Convert.ToInt32(data["pvp_lvl_6"]);

            return this;
        }
    }

    public class PropsRev : SqlDataBase
    {
        // ID
        public int id;
        // 品阶
        public int star;
        // 等级
        public int level;
        // 部件等级
        public int widget_level;
        // 租借时间（m）
        public int lease;
        // 无法升级
        public int bIsDisableUpgrade;
        // 无法进阶
        public int bIsDisablePromote;
        // 无法提升部件
        public int bIsDisableUpgradePart;
        // 无法成为材料
        public int bIsDisableAsMaterial;
        // 无法出售
        public int bIsDisableSell;
        // 在商店是否显示满级属性
        public int bIsDisableMaxAttrInShop;

        public static PropsRev Copy(PropsRev other)
        {
            PropsRev ret = new PropsRev();
            ret.id = other.id;
            ret.star = other.star;
            ret.level = other.level;
            ret.widget_level = other.widget_level;
            ret.lease = other.lease;
            ret.bIsDisableUpgrade = other.bIsDisableUpgrade;
            ret.bIsDisablePromote = other.bIsDisablePromote;
            ret.bIsDisableUpgradePart = other.bIsDisableUpgradePart;
            ret.bIsDisableAsMaterial = other.bIsDisableAsMaterial;
            ret.bIsDisableSell = other.bIsDisableSell;
            ret.bIsDisableMaxAttrInShop = other.bIsDisableMaxAttrInShop;

            return ret;
        }

        public override SqlDataBase InitWithAttributes(Dictionary<string, System.Object> data)
        {
            this.id = Convert.ToInt32(data["id"]);
            this.star = Convert.ToInt32(data["star"]);
            this.level = Convert.ToInt32(data["level"]);
            this.widget_level = Convert.ToInt32(data["widget_level"]);
            this.lease = Convert.ToInt32(data["lease"]);
            this.bIsDisableUpgrade = Convert.ToInt32(data["bIsDisableUpgrade"]);
            this.bIsDisablePromote = Convert.ToInt32(data["bIsDisablePromote"]);
            this.bIsDisableUpgradePart = Convert.ToInt32(data["bIsDisableUpgradePart"]);
            this.bIsDisableAsMaterial = Convert.ToInt32(data["bIsDisableAsMaterial"]);
            this.bIsDisableSell = Convert.ToInt32(data["bIsDisableSell"]);
            this.bIsDisableMaxAttrInShop = Convert.ToInt32(data["bIsDisableMaxAttrInShop"]);

            return this;
        }
    }

    public class Props : SqlDataBase
    {
        // 道具ID
        public int id;
        // 道具名称
        public string name;
        // 道具类型
        public int type;
        // 类型名称
        public string tname;
        // 二级分类
        public int sub_type;
        // 二级分类名称
        public string stname;
        // 出售价格
        public int price;
        // 经验
        public int exp;
        // 道具图标
        public string icon;
        // 道具特殊图标
        public string icon_special;
        // 道具颜色
        public int color;
        // 道具描述
        public string desc;

        public static Props Copy(Props other)
        {
            Props ret = new Props();
            ret.id = other.id;
            ret.name = other.name;
            ret.type = other.type;
            ret.tname = other.tname;
            ret.sub_type = other.sub_type;
            ret.stname = other.stname;
            ret.price = other.price;
            ret.exp = other.exp;
            ret.icon = other.icon;
            ret.icon_special = other.icon_special;
            ret.color = other.color;
            ret.desc = other.desc;

            return ret;
        }

        public override SqlDataBase InitWithAttributes(Dictionary<string, System.Object> data)
        {
            this.id = Convert.ToInt32(data["id"]);
            this.name = Convert.ToString(data["name"]);
            this.type = Convert.ToInt32(data["type"]);
            this.tname = Convert.ToString(data["tname"]);
            this.sub_type = Convert.ToInt32(data["sub_type"]);
            this.stname = Convert.ToString(data["stname"]);
            this.price = Convert.ToInt32(data["price"]);
            this.exp = Convert.ToInt32(data["exp"]);
            this.icon = Convert.ToString(data["icon"]);
            this.icon_special = Convert.ToString(data["icon_special"]);
            this.color = Convert.ToInt32(data["color"]);
            this.desc = Convert.ToString(data["desc"]);

            return this;
        }
    }

    public class SignAward : SqlDataBase
    {
        // 奖励ID
        public int id;
        // 月份
        public int month;
        // 天数
        public int days;
        // 道具ID
        public int item_id;
        // 奖励数量
        public int item_num;
        // 道具参数
        public int item_rev_id;
        // VIP奖励等级
        public int vip;
        // VIP奖励倍数
        public int x;

        public static SignAward Copy(SignAward other)
        {
            SignAward ret = new SignAward();
            ret.id = other.id;
            ret.month = other.month;
            ret.days = other.days;
            ret.item_id = other.item_id;
            ret.item_num = other.item_num;
            ret.item_rev_id = other.item_rev_id;
            ret.vip = other.vip;
            ret.x = other.x;

            return ret;
        }

        public override SqlDataBase InitWithAttributes(Dictionary<string, System.Object> data)
        {
            this.id = Convert.ToInt32(data["id"]);
            this.month = Convert.ToInt32(data["month"]);
            this.days = Convert.ToInt32(data["days"]);
            this.item_id = Convert.ToInt32(data["item_id"]);
            this.item_num = Convert.ToInt32(data["item_num"]);
            this.item_rev_id = Convert.ToInt32(data["item_rev_id"]);
            this.vip = Convert.ToInt32(data["vip"]);
            this.x = Convert.ToInt32(data["x"]);

            return this;
        }
    }

    public class BlessItem : SqlDataBase
    {
        // 祝福ID
        public int id;
        // 战斗模式
        public int scope;
        // 祝福类型
        public int type;
        // 祝福描述
        public string desc;
        // BUFFID
        public int buff_id;
        // 祝福目标
        public int target;

        public static BlessItem Copy(BlessItem other)
        {
            BlessItem ret = new BlessItem();
            ret.id = other.id;
            ret.scope = other.scope;
            ret.type = other.type;
            ret.desc = other.desc;
            ret.buff_id = other.buff_id;
            ret.target = other.target;

            return ret;
        }

        public override SqlDataBase InitWithAttributes(Dictionary<string, System.Object> data)
        {
            this.id = Convert.ToInt32(data["id"]);
            this.scope = Convert.ToInt32(data["scope"]);
            this.type = Convert.ToInt32(data["type"]);
            this.desc = Convert.ToString(data["desc"]);
            this.buff_id = Convert.ToInt32(data["buff_id"]);
            this.target = Convert.ToInt32(data["target"]);

            return this;
        }
    }

    public class PurchaseItem : SqlDataBase
    {
        // 商品ID
        public int id;
        // 商城分类
        public int store_type;
        // 二级分类
        public int shop_type;
        // 限购次数
        public int limit;
        // 活动开始时间
        public int start;
        // 活动结束时间
        public int end;
        // 商品名称
        public string name;
        // 商品描述
        public string desc;
        // 商品图标
        public string icon;
        // 是否打折
        public int discount;
        // 互斥组
        public int mutex;
        // 升序排列
        public int order;
        // 货币类型
        public int price_type;
        // 价格
        public int price;
        // 道具ID
        public int item1_id;
        // 数量
        public int item1_num;
        // 品阶
        public int item1_rev_id;
        // 
        public int item2_id;
        // 
        public int item2_num;
        // 
        public int item2_rev_id;
        // 
        public int item3_id;
        // 
        public int item3_num;
        // 
        public int item3_rev_id;
        // 
        public int item4_id;
        // 
        public int item4_num;
        // 
        public int item4_rev_id;
        // 
        public int item5_id;
        // 
        public int item5_num;
        // 
        public int item5_rev_id;
        // 
        public int item6_id;
        // 
        public int item6_num;
        // 
        public int item6_rev_id;

        public static PurchaseItem Copy(PurchaseItem other)
        {
            PurchaseItem ret = new PurchaseItem();
            ret.id = other.id;
            ret.store_type = other.store_type;
            ret.shop_type = other.shop_type;
            ret.limit = other.limit;
            ret.start = other.start;
            ret.end = other.end;
            ret.name = other.name;
            ret.desc = other.desc;
            ret.icon = other.icon;
            ret.discount = other.discount;
            ret.mutex = other.mutex;
            ret.order = other.order;
            ret.price_type = other.price_type;
            ret.price = other.price;
            ret.item1_id = other.item1_id;
            ret.item1_num = other.item1_num;
            ret.item1_rev_id = other.item1_rev_id;
            ret.item2_id = other.item2_id;
            ret.item2_num = other.item2_num;
            ret.item2_rev_id = other.item2_rev_id;
            ret.item3_id = other.item3_id;
            ret.item3_num = other.item3_num;
            ret.item3_rev_id = other.item3_rev_id;
            ret.item4_id = other.item4_id;
            ret.item4_num = other.item4_num;
            ret.item4_rev_id = other.item4_rev_id;
            ret.item5_id = other.item5_id;
            ret.item5_num = other.item5_num;
            ret.item5_rev_id = other.item5_rev_id;
            ret.item6_id = other.item6_id;
            ret.item6_num = other.item6_num;
            ret.item6_rev_id = other.item6_rev_id;

            return ret;
        }

        public override SqlDataBase InitWithAttributes(Dictionary<string, System.Object> data)
        {
            this.id = Convert.ToInt32(data["id"]);
            this.store_type = Convert.ToInt32(data["store_type"]);
            this.shop_type = Convert.ToInt32(data["shop_type"]);
            this.limit = Convert.ToInt32(data["limit"]);
            this.start = Convert.ToInt32(data["start"]);
            this.end = Convert.ToInt32(data["end"]);
            this.name = Convert.ToString(data["name"]);
            this.desc = Convert.ToString(data["desc"]);
            this.icon = Convert.ToString(data["icon"]);
            this.discount = Convert.ToInt32(data["discount"]);
            this.mutex = Convert.ToInt32(data["mutex"]);
            this.order = Convert.ToInt32(data["order"]);
            this.price_type = Convert.ToInt32(data["price_type"]);
            this.price = Convert.ToInt32(data["price"]);
            this.item1_id = Convert.ToInt32(data["item1_id"]);
            this.item1_num = Convert.ToInt32(data["item1_num"]);
            this.item1_rev_id = Convert.ToInt32(data["item1_rev_id"]);
            this.item2_id = Convert.ToInt32(data["item2_id"]);
            this.item2_num = Convert.ToInt32(data["item2_num"]);
            this.item2_rev_id = Convert.ToInt32(data["item2_rev_id"]);
            this.item3_id = Convert.ToInt32(data["item3_id"]);
            this.item3_num = Convert.ToInt32(data["item3_num"]);
            this.item3_rev_id = Convert.ToInt32(data["item3_rev_id"]);
            this.item4_id = Convert.ToInt32(data["item4_id"]);
            this.item4_num = Convert.ToInt32(data["item4_num"]);
            this.item4_rev_id = Convert.ToInt32(data["item4_rev_id"]);
            this.item5_id = Convert.ToInt32(data["item5_id"]);
            this.item5_num = Convert.ToInt32(data["item5_num"]);
            this.item5_rev_id = Convert.ToInt32(data["item5_rev_id"]);
            this.item6_id = Convert.ToInt32(data["item6_id"]);
            this.item6_num = Convert.ToInt32(data["item6_num"]);
            this.item6_rev_id = Convert.ToInt32(data["item6_rev_id"]);

            return this;
        }
    }

    public class BattlePrepareCfg : SqlDataBase
    {
        // 战前准备ID
        public int id;
        // 商品个数
        public int goods_count;
        // 商品ID
        public int goods_1;
        // 商品ID
        public int goods_2;
        // 商品ID
        public int goods_3;
        // 商品ID
        public int goods_4;
        // 商品ID
        public int goods_5;
        // 商品ID
        public int goods_6;

        public static BattlePrepareCfg Copy(BattlePrepareCfg other)
        {
            BattlePrepareCfg ret = new BattlePrepareCfg();
            ret.id = other.id;
            ret.goods_count = other.goods_count;
            ret.goods_1 = other.goods_1;
            ret.goods_2 = other.goods_2;
            ret.goods_3 = other.goods_3;
            ret.goods_4 = other.goods_4;
            ret.goods_5 = other.goods_5;
            ret.goods_6 = other.goods_6;

            return ret;
        }

        public override SqlDataBase InitWithAttributes(Dictionary<string, System.Object> data)
        {
            this.id = Convert.ToInt32(data["id"]);
            this.goods_count = Convert.ToInt32(data["goods_count"]);
            this.goods_1 = Convert.ToInt32(data["goods_1"]);
            this.goods_2 = Convert.ToInt32(data["goods_2"]);
            this.goods_3 = Convert.ToInt32(data["goods_3"]);
            this.goods_4 = Convert.ToInt32(data["goods_4"]);
            this.goods_5 = Convert.ToInt32(data["goods_5"]);
            this.goods_6 = Convert.ToInt32(data["goods_6"]);

            return this;
        }
    }

    public class DailyPurchaseItemPkg : SqlDataBase
    {
        // 随机包ID
        public int id;
        // 随机商店类型
        public int type;
        // 抽取个数
        public int count;

        public static DailyPurchaseItemPkg Copy(DailyPurchaseItemPkg other)
        {
            DailyPurchaseItemPkg ret = new DailyPurchaseItemPkg();
            ret.id = other.id;
            ret.type = other.type;
            ret.count = other.count;

            return ret;
        }

        public override SqlDataBase InitWithAttributes(Dictionary<string, System.Object> data)
        {
            this.id = Convert.ToInt32(data["id"]);
            this.type = Convert.ToInt32(data["type"]);
            this.count = Convert.ToInt32(data["count"]);

            return this;
        }
    }

    public class DailyPurchaseItemWeight : SqlDataBase
    {
        // 商品ID
        public int id;
        // 随机包ID
        public int pkg_id;

        public static DailyPurchaseItemWeight Copy(DailyPurchaseItemWeight other)
        {
            DailyPurchaseItemWeight ret = new DailyPurchaseItemWeight();
            ret.id = other.id;
            ret.pkg_id = other.pkg_id;

            return ret;
        }

        public override SqlDataBase InitWithAttributes(Dictionary<string, System.Object> data)
        {
            this.id = Convert.ToInt32(data["id"]);
            this.pkg_id = Convert.ToInt32(data["pkg_id"]);

            return this;
        }
    }

    public class ShopRefresh : SqlDataBase
    {
        // ID
        public int id;
        // 商店类型
        public int type;
        // 次数
        public int count;
        // 货币类型
        public int price_type;
        // 数量
        public int price;

        public static ShopRefresh Copy(ShopRefresh other)
        {
            ShopRefresh ret = new ShopRefresh();
            ret.id = other.id;
            ret.type = other.type;
            ret.count = other.count;
            ret.price_type = other.price_type;
            ret.price = other.price;

            return ret;
        }

        public override SqlDataBase InitWithAttributes(Dictionary<string, System.Object> data)
        {
            this.id = Convert.ToInt32(data["id"]);
            this.type = Convert.ToInt32(data["type"]);
            this.count = Convert.ToInt32(data["count"]);
            this.price_type = Convert.ToInt32(data["price_type"]);
            this.price = Convert.ToInt32(data["price"]);

            return this;
        }
    }

    public class GachaPkg : SqlDataBase
    {
        // 抽取包集合
        public int id;
        // 商品ID
        public int purchase_item_id;

        public static GachaPkg Copy(GachaPkg other)
        {
            GachaPkg ret = new GachaPkg();
            ret.id = other.id;
            ret.purchase_item_id = other.purchase_item_id;

            return ret;
        }

        public override SqlDataBase InitWithAttributes(Dictionary<string, System.Object> data)
        {
            this.id = Convert.ToInt32(data["id"]);
            this.purchase_item_id = Convert.ToInt32(data["purchase_item_id"]);

            return this;
        }
    }

    public class GachaSubPkg : SqlDataBase
    {
        // NO
        public int id;
        // 抽取包集合
        public int pkg_id;
        // 奖励包
        public int spkg_id;

        public static GachaSubPkg Copy(GachaSubPkg other)
        {
            GachaSubPkg ret = new GachaSubPkg();
            ret.id = other.id;
            ret.pkg_id = other.pkg_id;
            ret.spkg_id = other.spkg_id;

            return ret;
        }

        public override SqlDataBase InitWithAttributes(Dictionary<string, System.Object> data)
        {
            this.id = Convert.ToInt32(data["id"]);
            this.pkg_id = Convert.ToInt32(data["pkg_id"]);
            this.spkg_id = Convert.ToInt32(data["spkg_id"]);

            return this;
        }
    }

    public class GachaPkgItem : SqlDataBase
    {
        // NO
        public int id;
        // 奖励包
        public int spkg_id;
        // 道具ID
        public int prop_id;

        public static GachaPkgItem Copy(GachaPkgItem other)
        {
            GachaPkgItem ret = new GachaPkgItem();
            ret.id = other.id;
            ret.spkg_id = other.spkg_id;
            ret.prop_id = other.prop_id;

            return ret;
        }

        public override SqlDataBase InitWithAttributes(Dictionary<string, System.Object> data)
        {
            this.id = Convert.ToInt32(data["id"]);
            this.spkg_id = Convert.ToInt32(data["spkg_id"]);
            this.prop_id = Convert.ToInt32(data["prop_id"]);

            return this;
        }
    }

    public class MainTask : SqlDataBase
    {
        // 任务ID
        public int id;
        // 任务类型ID
        public int type;
        // 任务名称
        public string name;
        // 任务描述（{0}读取的是参数2）
        public string description;
        // 任务图标
        public string icon;
        // 解锁所需玩家等级
        public int unlock_lv;
        // 解锁所需完成关卡ID
        public int unlock_stage;
        // 参数1
        public int param1;
        // 参数2
        public int param2;
        // 参数3
        public int param3;
        // 奖励种类数量
        public int award_count;
        // 奖励1
        public int item1_id;
        // 阶次
        public int item1_rev_id;
        // 奖励1数量
        public int item1_num;
        // 奖励2
        public int item2_id;
        // 阶次
        public int item2_rev_id;
        // 奖励2数量
        public int item2_num;
        // 奖励3
        public int item3_id;
        // 阶次
        public int item3_rev_id;
        // 奖励3数量
        public int item3_num;

        public static MainTask Copy(MainTask other)
        {
            MainTask ret = new MainTask();
            ret.id = other.id;
            ret.type = other.type;
            ret.name = other.name;
            ret.description = other.description;
            ret.icon = other.icon;
            ret.unlock_lv = other.unlock_lv;
            ret.unlock_stage = other.unlock_stage;
            ret.param1 = other.param1;
            ret.param2 = other.param2;
            ret.param3 = other.param3;
            ret.award_count = other.award_count;
            ret.item1_id = other.item1_id;
            ret.item1_rev_id = other.item1_rev_id;
            ret.item1_num = other.item1_num;
            ret.item2_id = other.item2_id;
            ret.item2_rev_id = other.item2_rev_id;
            ret.item2_num = other.item2_num;
            ret.item3_id = other.item3_id;
            ret.item3_rev_id = other.item3_rev_id;
            ret.item3_num = other.item3_num;

            return ret;
        }

        public override SqlDataBase InitWithAttributes(Dictionary<string, System.Object> data)
        {
            this.id = Convert.ToInt32(data["id"]);
            this.type = Convert.ToInt32(data["type"]);
            this.name = Convert.ToString(data["name"]);
            this.description = Convert.ToString(data["description"]);
            this.icon = Convert.ToString(data["icon"]);
            this.unlock_lv = Convert.ToInt32(data["unlock_lv"]);
            this.unlock_stage = Convert.ToInt32(data["unlock_stage"]);
            this.param1 = Convert.ToInt32(data["param1"]);
            this.param2 = Convert.ToInt32(data["param2"]);
            this.param3 = Convert.ToInt32(data["param3"]);
            this.award_count = Convert.ToInt32(data["award_count"]);
            this.item1_id = Convert.ToInt32(data["item1_id"]);
            this.item1_rev_id = Convert.ToInt32(data["item1_rev_id"]);
            this.item1_num = Convert.ToInt32(data["item1_num"]);
            this.item2_id = Convert.ToInt32(data["item2_id"]);
            this.item2_rev_id = Convert.ToInt32(data["item2_rev_id"]);
            this.item2_num = Convert.ToInt32(data["item2_num"]);
            this.item3_id = Convert.ToInt32(data["item3_id"]);
            this.item3_rev_id = Convert.ToInt32(data["item3_rev_id"]);
            this.item3_num = Convert.ToInt32(data["item3_num"]);

            return this;
        }
    }

    public class DailyTask : SqlDataBase
    {
        // 任务ID
        public int id;
        // 任务类型ID
        public int type;
        // 任务系列ID
        public int series;
        // 任务阶段
        public int degree;
        // 任务名称
        public string name;
        // 任务描述（{0}读取的是参数2）
        public string description;
        // 任务图标
        public string icon;
        // 解锁所需玩家等级
        public int unlock_lv;
        // 解锁所需完成关卡ID
        public int unlock_stage;
        // 参数1
        public int param1;
        // 参数2
        public int param2;
        // 参数3
        public int param3;
        // 进度统计类型
        public int progress_type;
        // 奖励种类数量
        public int award_count;
        // 奖励1
        public int item1_id;
        // 参数1
        public int item1_rev_id;
        // 奖励1数量
        public int item1_num;
        // 奖励2
        public int item2_id;
        // 参数2
        public int item2_rev_id;
        // 奖励2数量
        public int item2_num;
        // 奖励3
        public int item3_id;
        // 参数3
        public int item3_rev_id;
        // 奖励3数量
        public int item3_num;
        // 开始时间
        public int shour;
        // 结束时间
        public int ehour;

        public static DailyTask Copy(DailyTask other)
        {
            DailyTask ret = new DailyTask();
            ret.id = other.id;
            ret.type = other.type;
            ret.series = other.series;
            ret.degree = other.degree;
            ret.name = other.name;
            ret.description = other.description;
            ret.icon = other.icon;
            ret.unlock_lv = other.unlock_lv;
            ret.unlock_stage = other.unlock_stage;
            ret.param1 = other.param1;
            ret.param2 = other.param2;
            ret.param3 = other.param3;
            ret.progress_type = other.progress_type;
            ret.award_count = other.award_count;
            ret.item1_id = other.item1_id;
            ret.item1_rev_id = other.item1_rev_id;
            ret.item1_num = other.item1_num;
            ret.item2_id = other.item2_id;
            ret.item2_rev_id = other.item2_rev_id;
            ret.item2_num = other.item2_num;
            ret.item3_id = other.item3_id;
            ret.item3_rev_id = other.item3_rev_id;
            ret.item3_num = other.item3_num;
            ret.shour = other.shour;
            ret.ehour = other.ehour;

            return ret;
        }

        public override SqlDataBase InitWithAttributes(Dictionary<string, System.Object> data)
        {
            this.id = Convert.ToInt32(data["id"]);
            this.type = Convert.ToInt32(data["type"]);
            this.series = Convert.ToInt32(data["series"]);
            this.degree = Convert.ToInt32(data["degree"]);
            this.name = Convert.ToString(data["name"]);
            this.description = Convert.ToString(data["description"]);
            this.icon = Convert.ToString(data["icon"]);
            this.unlock_lv = Convert.ToInt32(data["unlock_lv"]);
            this.unlock_stage = Convert.ToInt32(data["unlock_stage"]);
            this.param1 = Convert.ToInt32(data["param1"]);
            this.param2 = Convert.ToInt32(data["param2"]);
            this.param3 = Convert.ToInt32(data["param3"]);
            this.progress_type = Convert.ToInt32(data["progress_type"]);
            this.award_count = Convert.ToInt32(data["award_count"]);
            this.item1_id = Convert.ToInt32(data["item1_id"]);
            this.item1_rev_id = Convert.ToInt32(data["item1_rev_id"]);
            this.item1_num = Convert.ToInt32(data["item1_num"]);
            this.item2_id = Convert.ToInt32(data["item2_id"]);
            this.item2_rev_id = Convert.ToInt32(data["item2_rev_id"]);
            this.item2_num = Convert.ToInt32(data["item2_num"]);
            this.item3_id = Convert.ToInt32(data["item3_id"]);
            this.item3_rev_id = Convert.ToInt32(data["item3_rev_id"]);
            this.item3_num = Convert.ToInt32(data["item3_num"]);
            this.shour = Convert.ToInt32(data["shour"]);
            this.ehour = Convert.ToInt32(data["ehour"]);

            return this;
        }
    }

    public class Recharge : SqlDataBase
    {
        // 充值ID
        public int id;
        // 充值金额
        public float price;
        // 
        public int group;
        // 获得钻石
        public int diamond;
        // app_store
        public string app_store;
        // google_play
        public string google_play;

        public static Recharge Copy(Recharge other)
        {
            Recharge ret = new Recharge();
            ret.id = other.id;
            ret.price = other.price;
            ret.group = other.group;
            ret.diamond = other.diamond;
            ret.app_store = other.app_store;
            ret.google_play = other.google_play;

            return ret;
        }

        public override SqlDataBase InitWithAttributes(Dictionary<string, System.Object> data)
        {
            this.id = Convert.ToInt32(data["id"]);
            this.price = Convert.ToSingle(data["price"]);
            this.group = Convert.ToInt32(data["group"]);
            this.diamond = Convert.ToInt32(data["diamond"]);
            this.app_store = Convert.ToString(data["app_store"]);
            this.google_play = Convert.ToString(data["google_play"]);

            return this;
        }
    }

    public class NewbieTask : SqlDataBase
    {
        // 天数
        public int id;
        // 任务1
        public int task1;
        // 任务2
        public int task2;
        // 奖励ID
        public int item1_id;
        // 参数
        public int item1_rev_id;
        // 数量
        public int item1_num;
        // 奖励ID
        public int item2_id;
        // 参数
        public int item2_rev_id;
        // 数量
        public int item2_num;

        public static NewbieTask Copy(NewbieTask other)
        {
            NewbieTask ret = new NewbieTask();
            ret.id = other.id;
            ret.task1 = other.task1;
            ret.task2 = other.task2;
            ret.item1_id = other.item1_id;
            ret.item1_rev_id = other.item1_rev_id;
            ret.item1_num = other.item1_num;
            ret.item2_id = other.item2_id;
            ret.item2_rev_id = other.item2_rev_id;
            ret.item2_num = other.item2_num;

            return ret;
        }

        public override SqlDataBase InitWithAttributes(Dictionary<string, System.Object> data)
        {
            this.id = Convert.ToInt32(data["id"]);
            this.task1 = Convert.ToInt32(data["task1"]);
            this.task2 = Convert.ToInt32(data["task2"]);
            this.item1_id = Convert.ToInt32(data["item1_id"]);
            this.item1_rev_id = Convert.ToInt32(data["item1_rev_id"]);
            this.item1_num = Convert.ToInt32(data["item1_num"]);
            this.item2_id = Convert.ToInt32(data["item2_id"]);
            this.item2_rev_id = Convert.ToInt32(data["item2_rev_id"]);
            this.item2_num = Convert.ToInt32(data["item2_num"]);

            return this;
        }
    }

    public class NewbieTaskItem : SqlDataBase
    {
        // 任务ID
        public int id;
        // 任务类型
        public int type;
        // 任务描述
        public string desc;
        // 参数1
        public int param1;
        // 参数2
        public int param2;

        public static NewbieTaskItem Copy(NewbieTaskItem other)
        {
            NewbieTaskItem ret = new NewbieTaskItem();
            ret.id = other.id;
            ret.type = other.type;
            ret.desc = other.desc;
            ret.param1 = other.param1;
            ret.param2 = other.param2;

            return ret;
        }

        public override SqlDataBase InitWithAttributes(Dictionary<string, System.Object> data)
        {
            this.id = Convert.ToInt32(data["id"]);
            this.type = Convert.ToInt32(data["type"]);
            this.desc = Convert.ToString(data["desc"]);
            this.param1 = Convert.ToInt32(data["param1"]);
            this.param2 = Convert.ToInt32(data["param2"]);

            return this;
        }
    }

    public class GoldBuy : SqlDataBase
    {
        // 点金次数
        public int id;
        // 消耗钻石
        public int diamond;
        // 获得金币
        public int gold;

        public static GoldBuy Copy(GoldBuy other)
        {
            GoldBuy ret = new GoldBuy();
            ret.id = other.id;
            ret.diamond = other.diamond;
            ret.gold = other.gold;

            return ret;
        }

        public override SqlDataBase InitWithAttributes(Dictionary<string, System.Object> data)
        {
            this.id = Convert.ToInt32(data["id"]);
            this.diamond = Convert.ToInt32(data["diamond"]);
            this.gold = Convert.ToInt32(data["gold"]);

            return this;
        }
    }

    public class GoldBuyCrit : SqlDataBase
    {
        // 序号
        public int id;
        // 金币暴击倍数
        public int crit;

        public static GoldBuyCrit Copy(GoldBuyCrit other)
        {
            GoldBuyCrit ret = new GoldBuyCrit();
            ret.id = other.id;
            ret.crit = other.crit;

            return ret;
        }

        public override SqlDataBase InitWithAttributes(Dictionary<string, System.Object> data)
        {
            this.id = Convert.ToInt32(data["id"]);
            this.crit = Convert.ToInt32(data["crit"]);

            return this;
        }
    }

    public class EpBuy : SqlDataBase
    {
        // 体力购买次数
        public int id;
        // 消耗钻石
        public int diamond;
        // 购买体力值
        public int ep;

        public static EpBuy Copy(EpBuy other)
        {
            EpBuy ret = new EpBuy();
            ret.id = other.id;
            ret.diamond = other.diamond;
            ret.ep = other.ep;

            return ret;
        }

        public override SqlDataBase InitWithAttributes(Dictionary<string, System.Object> data)
        {
            this.id = Convert.ToInt32(data["id"]);
            this.diamond = Convert.ToInt32(data["diamond"]);
            this.ep = Convert.ToInt32(data["ep"]);

            return this;
        }
    }

    public class VipLevel : SqlDataBase
    {
        // vip等级
        public int id;
        // 累计充值钻石
        public int diamond;
        // 日常购买体力次数
        public int ep_count;
        // 日常点金次数
        public int bc_count;
        // 载具强化点上限
        public int vehicle_point;
        // 
        public int item1_id;
        // 
        public int item1_rev_id;
        // 
        public int item1_num;
        // 
        public int item2_id;
        // 
        public int item2_rev_id;
        // 
        public int item2_num;
        // 
        public int item3_id;
        // 
        public int item3_rev_id;
        // 
        public int item3_num;
        // 
        public int item4_id;
        // 
        public int item4_rev_id;
        // 
        public int item4_num;
        // 
        public int item5_id;
        // 
        public int item5_rev_id;
        // 
        public int item5_num;
        // 描述
        public string desc;
        // 关卡日常重置次数
        public int pve_reset;
        // 好友助战奖励提高%
        public int friend_help;
        // 挑战关卡复活次数
        public int chlg_reborn;
        // PVP功勋加成
        public float pvp_xp_factor;
        // 军衔经验加成%
        public float pvp_rank_factor;

        public static VipLevel Copy(VipLevel other)
        {
            VipLevel ret = new VipLevel();
            ret.id = other.id;
            ret.diamond = other.diamond;
            ret.ep_count = other.ep_count;
            ret.bc_count = other.bc_count;
            ret.vehicle_point = other.vehicle_point;
            ret.item1_id = other.item1_id;
            ret.item1_rev_id = other.item1_rev_id;
            ret.item1_num = other.item1_num;
            ret.item2_id = other.item2_id;
            ret.item2_rev_id = other.item2_rev_id;
            ret.item2_num = other.item2_num;
            ret.item3_id = other.item3_id;
            ret.item3_rev_id = other.item3_rev_id;
            ret.item3_num = other.item3_num;
            ret.item4_id = other.item4_id;
            ret.item4_rev_id = other.item4_rev_id;
            ret.item4_num = other.item4_num;
            ret.item5_id = other.item5_id;
            ret.item5_rev_id = other.item5_rev_id;
            ret.item5_num = other.item5_num;
            ret.desc = other.desc;
            ret.pve_reset = other.pve_reset;
            ret.friend_help = other.friend_help;
            ret.chlg_reborn = other.chlg_reborn;
            ret.pvp_xp_factor = other.pvp_xp_factor;
            ret.pvp_rank_factor = other.pvp_rank_factor;

            return ret;
        }

        public override SqlDataBase InitWithAttributes(Dictionary<string, System.Object> data)
        {
            this.id = Convert.ToInt32(data["id"]);
            this.diamond = Convert.ToInt32(data["diamond"]);
            this.ep_count = Convert.ToInt32(data["ep_count"]);
            this.bc_count = Convert.ToInt32(data["bc_count"]);
            this.vehicle_point = Convert.ToInt32(data["vehicle_point"]);
            this.item1_id = Convert.ToInt32(data["item1_id"]);
            this.item1_rev_id = Convert.ToInt32(data["item1_rev_id"]);
            this.item1_num = Convert.ToInt32(data["item1_num"]);
            this.item2_id = Convert.ToInt32(data["item2_id"]);
            this.item2_rev_id = Convert.ToInt32(data["item2_rev_id"]);
            this.item2_num = Convert.ToInt32(data["item2_num"]);
            this.item3_id = Convert.ToInt32(data["item3_id"]);
            this.item3_rev_id = Convert.ToInt32(data["item3_rev_id"]);
            this.item3_num = Convert.ToInt32(data["item3_num"]);
            this.item4_id = Convert.ToInt32(data["item4_id"]);
            this.item4_rev_id = Convert.ToInt32(data["item4_rev_id"]);
            this.item4_num = Convert.ToInt32(data["item4_num"]);
            this.item5_id = Convert.ToInt32(data["item5_id"]);
            this.item5_rev_id = Convert.ToInt32(data["item5_rev_id"]);
            this.item5_num = Convert.ToInt32(data["item5_num"]);
            this.desc = Convert.ToString(data["desc"]);
            this.pve_reset = Convert.ToInt32(data["pve_reset"]);
            this.friend_help = Convert.ToInt32(data["friend_help"]);
            this.chlg_reborn = Convert.ToInt32(data["chlg_reborn"]);
            this.pvp_xp_factor = Convert.ToSingle(data["pvp_xp_factor"]);
            this.pvp_rank_factor = Convert.ToSingle(data["pvp_rank_factor"]);

            return this;
        }
    }

    public class SignAccAward : SqlDataBase
    {
        // 奖励ID
        public int id;
        // 天数
        public int days;
        // 道具ID
        public int item1_id;
        // 奖励数量
        public int item1_num;
        // 道具参数
        public int item1_rev_id;
        // 道具ID
        public int item2_id;
        // 奖励数量
        public int item2_num;
        // 道具参数
        public int item2_rev_id;
        // 道具ID
        public int item3_id;
        // 奖励数量
        public int item3_num;
        // 道具参数
        public int item3_rev_id;
        // 道具ID
        public int item4_id;
        // 奖励数量
        public int item4_num;
        // 道具参数
        public int item4_rev_id;
        // 道具ID
        public int item5_id;
        // 奖励数量
        public int item5_num;
        // 道具参数
        public int item5_rev_id;

        public static SignAccAward Copy(SignAccAward other)
        {
            SignAccAward ret = new SignAccAward();
            ret.id = other.id;
            ret.days = other.days;
            ret.item1_id = other.item1_id;
            ret.item1_num = other.item1_num;
            ret.item1_rev_id = other.item1_rev_id;
            ret.item2_id = other.item2_id;
            ret.item2_num = other.item2_num;
            ret.item2_rev_id = other.item2_rev_id;
            ret.item3_id = other.item3_id;
            ret.item3_num = other.item3_num;
            ret.item3_rev_id = other.item3_rev_id;
            ret.item4_id = other.item4_id;
            ret.item4_num = other.item4_num;
            ret.item4_rev_id = other.item4_rev_id;
            ret.item5_id = other.item5_id;
            ret.item5_num = other.item5_num;
            ret.item5_rev_id = other.item5_rev_id;

            return ret;
        }

        public override SqlDataBase InitWithAttributes(Dictionary<string, System.Object> data)
        {
            this.id = Convert.ToInt32(data["id"]);
            this.days = Convert.ToInt32(data["days"]);
            this.item1_id = Convert.ToInt32(data["item1_id"]);
            this.item1_num = Convert.ToInt32(data["item1_num"]);
            this.item1_rev_id = Convert.ToInt32(data["item1_rev_id"]);
            this.item2_id = Convert.ToInt32(data["item2_id"]);
            this.item2_num = Convert.ToInt32(data["item2_num"]);
            this.item2_rev_id = Convert.ToInt32(data["item2_rev_id"]);
            this.item3_id = Convert.ToInt32(data["item3_id"]);
            this.item3_num = Convert.ToInt32(data["item3_num"]);
            this.item3_rev_id = Convert.ToInt32(data["item3_rev_id"]);
            this.item4_id = Convert.ToInt32(data["item4_id"]);
            this.item4_num = Convert.ToInt32(data["item4_num"]);
            this.item4_rev_id = Convert.ToInt32(data["item4_rev_id"]);
            this.item5_id = Convert.ToInt32(data["item5_id"]);
            this.item5_num = Convert.ToInt32(data["item5_num"]);
            this.item5_rev_id = Convert.ToInt32(data["item5_rev_id"]);

            return this;
        }
    }

    public class ReSignConfig : SqlDataBase
    {
        // 当月补签次数
        public int id;
        // 消耗货币类型
        public int price_type;
        // 消耗数量
        public int price_num;

        public static ReSignConfig Copy(ReSignConfig other)
        {
            ReSignConfig ret = new ReSignConfig();
            ret.id = other.id;
            ret.price_type = other.price_type;
            ret.price_num = other.price_num;

            return ret;
        }

        public override SqlDataBase InitWithAttributes(Dictionary<string, System.Object> data)
        {
            this.id = Convert.ToInt32(data["id"]);
            this.price_type = Convert.ToInt32(data["price_type"]);
            this.price_num = Convert.ToInt32(data["price_num"]);

            return this;
        }
    }

    public class BunkerConfig : SqlDataBase
    {
        // 掩体等级
        public int id;
        // 玩家掩体HP
        public int iPlayerBunkerHP;
        // 敌方掩体HP
        public int iEnemyBunkerHP;
        // 油桶HP
        public int iBarrelHP;
        // 油桶伤害
        public int iBarrelDemage;

        public static BunkerConfig Copy(BunkerConfig other)
        {
            BunkerConfig ret = new BunkerConfig();
            ret.id = other.id;
            ret.iPlayerBunkerHP = other.iPlayerBunkerHP;
            ret.iEnemyBunkerHP = other.iEnemyBunkerHP;
            ret.iBarrelHP = other.iBarrelHP;
            ret.iBarrelDemage = other.iBarrelDemage;

            return ret;
        }

        public override SqlDataBase InitWithAttributes(Dictionary<string, System.Object> data)
        {
            this.id = Convert.ToInt32(data["id"]);
            this.iPlayerBunkerHP = Convert.ToInt32(data["iPlayerBunkerHP"]);
            this.iEnemyBunkerHP = Convert.ToInt32(data["iEnemyBunkerHP"]);
            this.iBarrelHP = Convert.ToInt32(data["iBarrelHP"]);
            this.iBarrelDemage = Convert.ToInt32(data["iBarrelDemage"]);

            return this;
        }
    }

    public class MailConfig : SqlDataBase
    {
        // id
        public int id;
        // 发件人
        public string sender;
        // 标题
        public string title;
        // 内容
        public string content;

        public static MailConfig Copy(MailConfig other)
        {
            MailConfig ret = new MailConfig();
            ret.id = other.id;
            ret.sender = other.sender;
            ret.title = other.title;
            ret.content = other.content;

            return ret;
        }

        public override SqlDataBase InitWithAttributes(Dictionary<string, System.Object> data)
        {
            this.id = Convert.ToInt32(data["id"]);
            this.sender = Convert.ToString(data["sender"]);
            this.title = Convert.ToString(data["title"]);
            this.content = Convert.ToString(data["content"]);

            return this;
        }
    }

    public class LoadTip : SqlDataBase
    {
        // id
        public int id;
        // 类型
        public int type;
        // 描述
        public string desc;

        public static LoadTip Copy(LoadTip other)
        {
            LoadTip ret = new LoadTip();
            ret.id = other.id;
            ret.type = other.type;
            ret.desc = other.desc;

            return ret;
        }

        public override SqlDataBase InitWithAttributes(Dictionary<string, System.Object> data)
        {
            this.id = Convert.ToInt32(data["id"]);
            this.type = Convert.ToInt32(data["type"]);
            this.desc = Convert.ToString(data["desc"]);

            return this;
        }
    }

    public class Announcement : SqlDataBase
    {
        // 公告ID
        public int id;
        // 开始时间
        public int start;
        // 结束时间
        public int end;
        // 游戏公告/精彩活动
        public int type;
        // 按钮HOT角标
        public string hot;
        // 按钮HOT角标颜色
        public int icon;
        // 升序排序
        public int orders;
        // 前往类型
        public int gotype;
        // 按钮文字
        public string txt;
        // 标题文字
        public string title;
        // 活动内容
        public string content;

        public static Announcement Copy(Announcement other)
        {
            Announcement ret = new Announcement();
            ret.id = other.id;
            ret.start = other.start;
            ret.end = other.end;
            ret.type = other.type;
            ret.hot = other.hot;
            ret.icon = other.icon;
            ret.orders = other.orders;
            ret.gotype = other.gotype;
            ret.txt = other.txt;
            ret.title = other.title;
            ret.content = other.content;

            return ret;
        }

        public override SqlDataBase InitWithAttributes(Dictionary<string, System.Object> data)
        {
            this.id = Convert.ToInt32(data["id"]);
            this.start = Convert.ToInt32(data["start"]);
            this.end = Convert.ToInt32(data["end"]);
            this.type = Convert.ToInt32(data["type"]);
            this.hot = Convert.ToString(data["hot"]);
            this.icon = Convert.ToInt32(data["icon"]);
            this.orders = Convert.ToInt32(data["orders"]);
            this.gotype = Convert.ToInt32(data["gotype"]);
            this.txt = Convert.ToString(data["txt"]);
            this.title = Convert.ToString(data["title"]);
            this.content = Convert.ToString(data["content"]);

            return this;
        }
    }

    public class LansquenetSkill : SqlDataBase
    {
        // 序号
        public int id;
        // 技能ID
        public int skill_id;
        // 佣兵星级
        public int star;
        // 是否主动释放
        public int can_cast;
        // 技能类型
        public int type;
        // 数值类型
        public int param1_type;
        // 参数1
        public float param1;
        // 参数2
        public float param2;
        // 参数3
        public float param3;

        public static LansquenetSkill Copy(LansquenetSkill other)
        {
            LansquenetSkill ret = new LansquenetSkill();
            ret.id = other.id;
            ret.skill_id = other.skill_id;
            ret.star = other.star;
            ret.can_cast = other.can_cast;
            ret.type = other.type;
            ret.param1_type = other.param1_type;
            ret.param1 = other.param1;
            ret.param2 = other.param2;
            ret.param3 = other.param3;

            return ret;
        }

        public override SqlDataBase InitWithAttributes(Dictionary<string, System.Object> data)
        {
            this.id = Convert.ToInt32(data["id"]);
            this.skill_id = Convert.ToInt32(data["skill_id"]);
            this.star = Convert.ToInt32(data["star"]);
            this.can_cast = Convert.ToInt32(data["can_cast"]);
            this.type = Convert.ToInt32(data["type"]);
            this.param1_type = Convert.ToInt32(data["param1_type"]);
            this.param1 = Convert.ToSingle(data["param1"]);
            this.param2 = Convert.ToSingle(data["param2"]);
            this.param3 = Convert.ToSingle(data["param3"]);

            return this;
        }
    }

    public class RevivalNeeds : SqlDataBase
    {
        // id
        public int id;
        // 次数
        public int times;
        // 消耗钻石
        public int price;

        public static RevivalNeeds Copy(RevivalNeeds other)
        {
            RevivalNeeds ret = new RevivalNeeds();
            ret.id = other.id;
            ret.times = other.times;
            ret.price = other.price;

            return ret;
        }

        public override SqlDataBase InitWithAttributes(Dictionary<string, System.Object> data)
        {
            this.id = Convert.ToInt32(data["id"]);
            this.times = Convert.ToInt32(data["times"]);
            this.price = Convert.ToInt32(data["price"]);

            return this;
        }
    }

    public class StoreWeaponPreview : SqlDataBase
    {
        // ID
        public int id;
        // 枪械ID
        public int weapon_id;
        // 颜色
        public int color;

        public static StoreWeaponPreview Copy(StoreWeaponPreview other)
        {
            StoreWeaponPreview ret = new StoreWeaponPreview();
            ret.id = other.id;
            ret.weapon_id = other.weapon_id;
            ret.color = other.color;

            return ret;
        }

        public override SqlDataBase InitWithAttributes(Dictionary<string, System.Object> data)
        {
            this.id = Convert.ToInt32(data["id"]);
            this.weapon_id = Convert.ToInt32(data["weapon_id"]);
            this.color = Convert.ToInt32(data["color"]);

            return this;
        }
    }

    public class EventGroup : SqlDataBase
    {
        // 活动集合
        public int id;
        // 开始时间
        public int stime;
        // 截止时间
        public int etime;
        // 消失时间
        public int tag_time;
        // 写死
        public int special;
        // 开启周期
        public string disp_date;
        // 角标文字
        public string tag_txt;
        // 角标颜色
        public int tag_color;
        // 活动名称
        public string name;
        // 显示类型
        public int disp_type;
        // 前往类型
        public int go_type;
        // 图片
        public string adv;
        // 文字1
        public string txt1;
        // 文字2
        public string txt2;
        // 排序
        public int sort;

        public static EventGroup Copy(EventGroup other)
        {
            EventGroup ret = new EventGroup();
            ret.id = other.id;
            ret.stime = other.stime;
            ret.etime = other.etime;
            ret.tag_time = other.tag_time;
            ret.special = other.special;
            ret.disp_date = other.disp_date;
            ret.tag_txt = other.tag_txt;
            ret.tag_color = other.tag_color;
            ret.name = other.name;
            ret.disp_type = other.disp_type;
            ret.go_type = other.go_type;
            ret.adv = other.adv;
            ret.txt1 = other.txt1;
            ret.txt2 = other.txt2;
            ret.sort = other.sort;

            return ret;
        }

        public override SqlDataBase InitWithAttributes(Dictionary<string, System.Object> data)
        {
            this.id = Convert.ToInt32(data["id"]);
            this.stime = Convert.ToInt32(data["stime"]);
            this.etime = Convert.ToInt32(data["etime"]);
            this.tag_time = Convert.ToInt32(data["tag_time"]);
            this.special = Convert.ToInt32(data["special"]);
            this.disp_date = Convert.ToString(data["disp_date"]);
            this.tag_txt = Convert.ToString(data["tag_txt"]);
            this.tag_color = Convert.ToInt32(data["tag_color"]);
            this.name = Convert.ToString(data["name"]);
            this.disp_type = Convert.ToInt32(data["disp_type"]);
            this.go_type = Convert.ToInt32(data["go_type"]);
            this.adv = Convert.ToString(data["adv"]);
            this.txt1 = Convert.ToString(data["txt1"]);
            this.txt2 = Convert.ToString(data["txt2"]);
            this.sort = Convert.ToInt32(data["sort"]);

            return this;
        }
    }

    public class EventItem : SqlDataBase
    {
        // 活动id
        public int id;
        // 活动集合
        public int gid;
        // 前往类型
        public int go_type;
        // 前往文字
        public string go_txt;
        // 开始时间
        public int stime;
        // 截止时间
        public int etime;
        // 每天活动开始时间
        public int shour;
        // 每天活动截止时间
        public int ehour;
        // 领奖周期
        public int atype;
        // 前置活动
        public int pre_event;
        // 运营活动类型
        public int type;
        // 参数1
        public int param1;
        // 参数2
        public int param2;
        // 参数3
        public float param3;
        // 邮件
        public int mail;
        // 物品id
        public int item1_id;
        // 物品数量
        public int item1_num;
        // 物品参数
        public int item1_rev_id;
        // 物品id
        public int item2_id;
        // 物品数量
        public int item2_num;
        // 物品参数
        public int item2_rev_id;
        // 物品id
        public int item3_id;
        // 物品数量
        public int item3_num;
        // 物品参数
        public int item3_rev_id;

        public static EventItem Copy(EventItem other)
        {
            EventItem ret = new EventItem();
            ret.id = other.id;
            ret.gid = other.gid;
            ret.go_type = other.go_type;
            ret.go_txt = other.go_txt;
            ret.stime = other.stime;
            ret.etime = other.etime;
            ret.shour = other.shour;
            ret.ehour = other.ehour;
            ret.atype = other.atype;
            ret.pre_event = other.pre_event;
            ret.type = other.type;
            ret.param1 = other.param1;
            ret.param2 = other.param2;
            ret.param3 = other.param3;
            ret.mail = other.mail;
            ret.item1_id = other.item1_id;
            ret.item1_num = other.item1_num;
            ret.item1_rev_id = other.item1_rev_id;
            ret.item2_id = other.item2_id;
            ret.item2_num = other.item2_num;
            ret.item2_rev_id = other.item2_rev_id;
            ret.item3_id = other.item3_id;
            ret.item3_num = other.item3_num;
            ret.item3_rev_id = other.item3_rev_id;

            return ret;
        }

        public override SqlDataBase InitWithAttributes(Dictionary<string, System.Object> data)
        {
            this.id = Convert.ToInt32(data["id"]);
            this.gid = Convert.ToInt32(data["gid"]);
            this.go_type = Convert.ToInt32(data["go_type"]);
            this.go_txt = Convert.ToString(data["go_txt"]);
            this.stime = Convert.ToInt32(data["stime"]);
            this.etime = Convert.ToInt32(data["etime"]);
            this.shour = Convert.ToInt32(data["shour"]);
            this.ehour = Convert.ToInt32(data["ehour"]);
            this.atype = Convert.ToInt32(data["atype"]);
            this.pre_event = Convert.ToInt32(data["pre_event"]);
            this.type = Convert.ToInt32(data["type"]);
            this.param1 = Convert.ToInt32(data["param1"]);
            this.param2 = Convert.ToInt32(data["param2"]);
            this.param3 = Convert.ToSingle(data["param3"]);
            this.mail = Convert.ToInt32(data["mail"]);
            this.item1_id = Convert.ToInt32(data["item1_id"]);
            this.item1_num = Convert.ToInt32(data["item1_num"]);
            this.item1_rev_id = Convert.ToInt32(data["item1_rev_id"]);
            this.item2_id = Convert.ToInt32(data["item2_id"]);
            this.item2_num = Convert.ToInt32(data["item2_num"]);
            this.item2_rev_id = Convert.ToInt32(data["item2_rev_id"]);
            this.item3_id = Convert.ToInt32(data["item3_id"]);
            this.item3_num = Convert.ToInt32(data["item3_num"]);
            this.item3_rev_id = Convert.ToInt32(data["item3_rev_id"]);

            return this;
        }
    }

    public class RankAward : SqlDataBase
    {
        // 序号
        public int id;
        // 类型
        public int type;
        // 开始名次
        public int start;
        // 结束名次
        public int end;
        // 物品id
        public int item1_id;
        // 物品数量
        public int item1_num;
        // 物品参数
        public int item1_rev_id;
        // 物品id
        public int item2_id;
        // 物品数量
        public int item2_num;
        // 物品参数
        public int item2_rev_id;
        // 物品id
        public int item3_id;
        // 物品数量
        public int item3_num;
        // 物品参数
        public int item3_rev_id;
        // 物品id
        public int item4_id;
        // 物品数量
        public int item4_num;
        // 物品参数
        public int item4_rev_id;
        // 物品id
        public int item5_id;
        // 物品数量
        public int item5_num;
        // 物品参数
        public int item5_rev_id;

        public static RankAward Copy(RankAward other)
        {
            RankAward ret = new RankAward();
            ret.id = other.id;
            ret.type = other.type;
            ret.start = other.start;
            ret.end = other.end;
            ret.item1_id = other.item1_id;
            ret.item1_num = other.item1_num;
            ret.item1_rev_id = other.item1_rev_id;
            ret.item2_id = other.item2_id;
            ret.item2_num = other.item2_num;
            ret.item2_rev_id = other.item2_rev_id;
            ret.item3_id = other.item3_id;
            ret.item3_num = other.item3_num;
            ret.item3_rev_id = other.item3_rev_id;
            ret.item4_id = other.item4_id;
            ret.item4_num = other.item4_num;
            ret.item4_rev_id = other.item4_rev_id;
            ret.item5_id = other.item5_id;
            ret.item5_num = other.item5_num;
            ret.item5_rev_id = other.item5_rev_id;

            return ret;
        }

        public override SqlDataBase InitWithAttributes(Dictionary<string, System.Object> data)
        {
            this.id = Convert.ToInt32(data["id"]);
            this.type = Convert.ToInt32(data["type"]);
            this.start = Convert.ToInt32(data["start"]);
            this.end = Convert.ToInt32(data["end"]);
            this.item1_id = Convert.ToInt32(data["item1_id"]);
            this.item1_num = Convert.ToInt32(data["item1_num"]);
            this.item1_rev_id = Convert.ToInt32(data["item1_rev_id"]);
            this.item2_id = Convert.ToInt32(data["item2_id"]);
            this.item2_num = Convert.ToInt32(data["item2_num"]);
            this.item2_rev_id = Convert.ToInt32(data["item2_rev_id"]);
            this.item3_id = Convert.ToInt32(data["item3_id"]);
            this.item3_num = Convert.ToInt32(data["item3_num"]);
            this.item3_rev_id = Convert.ToInt32(data["item3_rev_id"]);
            this.item4_id = Convert.ToInt32(data["item4_id"]);
            this.item4_num = Convert.ToInt32(data["item4_num"]);
            this.item4_rev_id = Convert.ToInt32(data["item4_rev_id"]);
            this.item5_id = Convert.ToInt32(data["item5_id"]);
            this.item5_num = Convert.ToInt32(data["item5_num"]);
            this.item5_rev_id = Convert.ToInt32(data["item5_rev_id"]);

            return this;
        }
    }

    public class NewbieSignAward : SqlDataBase
    {
        // ID
        public int id;
        // 物品1
        public int item1_id;
        // 
        public int item1_num;
        // 
        public int item1_rev_id;

        public static NewbieSignAward Copy(NewbieSignAward other)
        {
            NewbieSignAward ret = new NewbieSignAward();
            ret.id = other.id;
            ret.item1_id = other.item1_id;
            ret.item1_num = other.item1_num;
            ret.item1_rev_id = other.item1_rev_id;

            return ret;
        }

        public override SqlDataBase InitWithAttributes(Dictionary<string, System.Object> data)
        {
            this.id = Convert.ToInt32(data["id"]);
            this.item1_id = Convert.ToInt32(data["item1_id"]);
            this.item1_num = Convert.ToInt32(data["item1_num"]);
            this.item1_rev_id = Convert.ToInt32(data["item1_rev_id"]);

            return this;
        }
    }

}